import React from 'react'
import { Context } from '../App'
import { useContext } from 'react'

export default function UseContextSample() {

    const {username} = useContext(Context)
  return (
    <div>
        UseContextSample
        <br/>
        {username}
    </div>
  )
}
