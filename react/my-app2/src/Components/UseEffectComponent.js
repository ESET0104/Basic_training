import React, { useEffect, useState } from 'react'

export default function UseEffectComponent() {

    const suggestions = [
        "macbook",
        "vivo",
        "xiaomi",
        "hp"
    ]

    const [recommend, setRecommend] = useState([])
    const[search, setSearch] = useState("");

    useEffect(()=>{
        setRecommend(suggestions.filter((element) => element.includes(search)));
    }, [search]);
  return (
    <div>
        <input value = {search} onChange = {(e) => setSearch(e.target.value)} ></input>
        {recommend.map((rec,index) => (<div key={index} >{index}.{rec}</div>))}
    </div>
  )
}
