import React from 'react'

export default function ButtonComponent({label, onClick}) {
  return (
    <div>
        <button onClick={onClick} >
            {label}
        </button>
    </div>
  )
}
