import React from 'react'
import { Link } from 'react-router-dom'

export default function NavBar() {
  return (
    <div>
      Navbar &nbsp; &rarr;
      <Link to='/'><button>home</button></Link>
      <Link to='/about'><button>about</button></Link> 
      <Link to='/api' ><button>Api</button> </Link>
    </div>
  )
}
