import React from 'react'
import { useRef } from 'react'

function UseRefComponent() {
    const inputElement = useRef(null)
    const focusHandler = () =>{
        inputElement.current.focus();
    }

  return (
    <div>
        welcome to the useRef hook
        <br/>
        <input ref={inputElement} />
        <br/>
        <button onClick={focusHandler} >focus</button>
    </div>
  )
}

export default UseRefComponent