import { useState, useEffect } from "react";
import axios from 'axios'

const useFetch = (url) => {
    const [loading, setLoading] = useState(false)
    const [data, setData] = useState(null)
    const [error, setError] = useState(null)

    const getData= async ()=>{
        try{
            setLoading(true)
            const response = await axios.get(url)
            console.log(response.data)
            setData(data)
        }
        catch{
            setError(error)
        }
        finally {
            setLoading(false)
        }
            
        
    }
    useEffect(()=>{getData()},[]);
    return [loading, data, error]

}
export {useFetch}