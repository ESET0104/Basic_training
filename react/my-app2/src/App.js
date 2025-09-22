
import './App.css';
import { createContext, useState } from 'react';
import UseContextSample from './Components/UseContextSample';

const Context = createContext();
export {Context};

function App() {
  const [count, setCount] = useState(0)
  const [username, setUsername] = useState("Mano")


  return (
    <Context.Provider value={{count, setCount, username, setUsername}} >
      <UseContextSample/>
    </Context.Provider>
    
  );
}

export default App;
