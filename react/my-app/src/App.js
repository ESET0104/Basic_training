
// import { useState } from 'react';
// import './App.css';
 
// function App() {
//   const ContainerStyle = {
//     flexDirection: 'column', 
//     justifyContent: 'center', 
//     alignItems: 'center', 
    
//   };
 
//   const [counter, setCounter]= useState(0);
 
//   const buttonHandler1 = () => {
//     setCounter(counter+1)
//   }
 
//    const buttonHandler2 = () => {
//     setCounter(counter-1)
//   }
//   return (
//     <div style = {ContainerStyle}>
//       <p> {counter}</p>
  
//       <button onClick={buttonHandler1}> increment </button>
//       <button onClick={buttonHandler2}> decrement </button>
//     </div>
//   );
   
// }
 
// export default App;

import React, { useState } from 'react';

function App() {
  const [counter, setCounter] = useState(0);

  const containerStyle = {
    display: 'flex',
    justifyContent: 'center', // Centers content horizontally
    alignItems: 'center',     // Centers content vertically
    minHeight: '100vh',       // Ensures the container takes full viewport height
    flexDirection: 'column',  // Stacks children vertically
    gap: '20px',              // Adds space between elements
  };

  const buttonHandler1 = () => {
    setCounter(counter+1)
  }
 
  const buttonHandler2 = () => {
    setCounter(counter-1)
  }

  return (
    <div style={containerStyle}>
      <div >{counter}</div>
      <div style={{flexDirection:"row"}}>
      <button onClick={buttonHandler1}> increment </button>
      <button onClick={buttonHandler2}> decrement </button>
      </div>
      
    </div>
  );
}

export default App;























 