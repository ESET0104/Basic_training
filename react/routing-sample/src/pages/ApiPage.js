import React from 'react'
import { useFetch } from '../hooks/UseFetch'

export default function ApiPage() {
    const [loading, data, error] = useFetch("https://jsonplaceholder.typicode.com/posts")
  return (
    <div>
        {
            loading && <>loading...</>
        }
        {
            !loading && error && <>{error.message}</>
        }
        {
            !loading && !error && data && data.map((element)=> <div key={element.id} >{element.id}. {element.title}</div>)
        }
    </div>
  )
}
