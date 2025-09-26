import React from 'react';
import { useTheme } from '../context/ThemeContext';

const ThemeSwitcher = () => {
  const { theme, toggleTheme } = useTheme();

  const styles = {
    light: {
      backgroundColor: 'white',
      color: 'black',
      padding: '20px',
      minHeight: '100vh'
    },
    dark: {
      backgroundColor: '#333',
      color: 'white',
      padding: '20px',
      minHeight: '100vh'
    }
  };

  return (
    <div style={styles[theme]}>
      <h1>Hello Students!</h1>
      <button onClick={toggleTheme}>Toggle Theme</button>
    </div>
  );
};

export default ThemeSwitcher;