import { useState } from 'react'
import './App.css'
import ButtonComponent from './Components/ButtonComponent'

function App() {
  const [count, setCount] = useState(0)

  const handleIncrement =()=> {
    setCount(count+1)
    console.log("increment Clicked")
  }

  const handleDecrement = () =>{
    setCount(count-1)
    console.log("Decrement Clicked")
  }


  return (
    <>
      <div style={{fontSize: '40px', textAlign: 'center', marginBottom: '20px' }}>
        count: {count}
      </div>
      <div style={{ 
        display: 'flex', 
        gap: '10px', 
        justifyContent: 'center',
        alignItems: 'center' 
      }}>
        <ButtonComponent label="Increment" onClick={handleIncrement} />
        <ButtonComponent label="Decrement" onClick={handleDecrement} />
      </div>
      
    </>
  )
}

export default App
