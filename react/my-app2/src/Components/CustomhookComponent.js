import React, { useState, useEffect } from 'react'

const useFetch = (url) =>{
    const [data,setData] = useState([])
    const [loading, setLoading] = useState(false)
    const [error, setError] = useState(null)
    const getData = ()=>{
        setLoading(true)
        fetch(url)
        .then((data)=>data.json())
        .then((data)=>setData(data))
        .catch((error)=>setError(error.message))
        .finally(()=>{setLoading(false)})
    }

    useEffect(getData,[])
    return [loading,data,error]
}

const useFetchJson = (url) =>{
    const [data,setData] = useState([])
    const [loading, setLoading] = useState(false)
    const [error, setError] = useState(null)
    const getData = ()=>{
        setLoading(true)
        fetch(url)
        .then((data)=>data.json())
        .then((data)=>setData(data))
        .catch((error)=>setError(error.message))
        .finally(()=>{setLoading(false)})
    }

    useEffect(getData,[])
    return {loading,data,error}
}

export default function CustomhookComponent() {
    //const [loading, data, error] = useFetch('https://jsonplaceholder.typicode.com/posts')
    const {loading, data, error} = useFetchJson('https://jsonplaceholder.typicode.com/posts')
    return (
        <div>
            {
                loading?<>loading...</>:<></>
            }
            {
                error && <>{error}</>
            }
            {
                data.map((item)=><div key={item.id} >{item.id}. {item.title}</div>)
            }
        </div>
    )
}
