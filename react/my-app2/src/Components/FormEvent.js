import { useState } from "react"

function FormEvent() {
    const [Username, setUsername] = useState("");
    const [Password, setPassword] = useState("");

    const onChangeHandler = (event) => {
        setUsername(event.target.value)
        console.log(Username)
    }
    const passwordHandler = (event) => {
        setPassword(event.target.value)
    }

    const buttonHandler = (event) => {
        if(Password === "Mano"){
            alert("log in success")
        }
    }

    return (
        <div>
            <input type='text' value={Username} placeholder="type your username" onChange={onChangeHandler}/>
            <input type= 'text' value={Password} placeholder="type your password" onChange={passwordHandler}/>
            <button onClick = {buttonHandler}>LOG IN</button>
        </div>
        
        
    )
    }

export default FormEvent