
import './App.css';
import NavBar from './Components/NavBar';
import AboutPage from './pages/AboutPage';
import HomePage from './pages/HomePage';
import ApiPage from './pages/ApiPage';
import {BrowserRouter, Routes, Route} from 'react-router-dom';

function App() {
  return (
    <>
      <BrowserRouter>
      <NavBar/>
        <Routes>
          <Route path="/" element={<HomePage/>} />
          <Route path="/about" element={<AboutPage/>}/>
          <Route path="/api" element={<ApiPage/>} />
        </Routes>
      </BrowserRouter>
      footer
    </>
  );
}

export default App;
