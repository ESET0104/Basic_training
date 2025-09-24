import React, { useState, useEffect } from 'react';

const MouseTracker = () => {
  const [position, setPosition] = useState({ x: 0, y: 0 });

  useEffect(() => {
    const handleMouseMove = (event) => {
      setPosition({
        x: event.clientX,
        y: event.clientY
      });
    };

    window.addEventListener('mousemove', handleMouseMove);

    return () => {
      window.removeEventListener('mousemove', handleMouseMove);
    };
  }, []);

  return (
    <div>
      <h2>Mouse Tracker</h2>
      <div style={{
        backgroundColor: "black",
        padding: "20px",
        borderRadius: "20px"
        
      }}>
        <h3>Current Mouse Position:</h3>
        <p>X: {position.x}</p>
        <p>Y: {position.y}</p>
      </div>
    </div>
  );
};

export default MouseTracker;