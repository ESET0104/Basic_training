import React from 'react'
import { useState } from 'react';

function LoginFormComponent() {

    const [loginState, setloginState] = useState({
        username:"",
        password:""
    });

    const onUsernameChangeHandler = (e) => {
        setloginState({
            ...loginState,
            username: e.target.value
        })
    }

    const onPasswordChangeHandler = (e) => {
        setloginState({
            ...loginState,
            password: e.target.value
        })
    }

    const onSubmitHandler = (e) => {
        e.preventDefault();
        if(loginState.username !== "username"){
            alert("invalid username")
            return
        }

        if(loginState.password !== "password"){
            alert("wrong password")
            return
        }

        alert("login successful")
    }

  return (
    <>
        Welcome to the Login Page
        <br />
        <form onSubmit={onSubmitHandler} >
            <input name="Username"type="text" value={loginState.username} onChange={onUsernameChangeHandler} />
            <br />
            <input name="Password" type="password" value={loginState.password} onChange={onPasswordChangeHandler} />
            <br />
            <button type="submit" >Login</button>
            <button type="reset" >reset</button>
        </form>
    </>
  )
}

export default LoginFormComponent