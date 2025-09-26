import { ThemeProvider } from './context/ThemeContext';
import ThemeSwitcher from './Components/ThemeSwitcherComponent';
import './App.css'

function App() {
  return (
    <ThemeProvider>
      <ThemeSwitcher />
    </ThemeProvider>
  )
}

export default App
