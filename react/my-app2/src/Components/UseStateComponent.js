import React, { useState } from 'react'

function UseStateComponent() {
const [count, setCount] = useState(0);
const onButtonClickHandler = ()=>{
    setCount(prev=>prev+1)
}

  return (
    <div>
        
    </div>
  )
}

export default UseStateComponent