

import { useState } from 'react';

function App() {
  const [counter, setCounter] = useState(0);

  const containerStyle = {
    display: 'flex',
    justifyContent: 'center', 
    alignItems: 'center',     
    minHeight: '100vh',       
    flexDirection: 'column',  
    gap: '20px',              
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























 