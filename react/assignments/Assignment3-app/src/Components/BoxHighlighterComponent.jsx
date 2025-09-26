import { useState, useRef } from 'react';

export default function BoxHighlighterComponent() {
  const boxRefs = useRef([]);
  const [currentIndex, setCurrentIndex] = useState(-1);

  const highlightNextBox = () => {
    if (currentIndex >= 0 && boxRefs.current[currentIndex]) {
      boxRefs.current[currentIndex].style.border = '2px solid transparent';
    }

    const nextIndex = (currentIndex + 1) % 3;
    setCurrentIndex(nextIndex);

    if (boxRefs.current[nextIndex]) {
      boxRefs.current[nextIndex].style.border = '4px solid yellow';
      
    }
  };

  return (
    <div style={{ padding: '20px', textAlign: 'center' }}>
      <h2>Color Box Highlighter</h2>
      
      <div style={{ display: 'flex', justifyContent: 'center', gap: '20px', margin: '30px 0' }}>
        <div
          ref={el => boxRefs.current[0] = el}
          style={{
            width: '100px',
            height: '100px',
            backgroundColor: 'red',
            borderRadius: '8px'
          }}
        >
          <span style={{ color: 'white', lineHeight: '100px' }}>Red</span>
        </div>

        <div
          ref={el => boxRefs.current[1] = el}
          style={{
            width: '100px',
            height: '100px',
            backgroundColor: 'green',
            borderRadius: '8px'
          }}
        >
          <span style={{ color: 'white', lineHeight: '100px' }}>Green</span>
        </div>

        <div
          ref={el => boxRefs.current[2] = el}
          style={{
            width: '100px',
            height: '100px',
            backgroundColor: 'blue',
            borderRadius: '8px'
          }}
        >
          <span style={{ color: 'white', lineHeight: '100px' }}>Blue</span>
        </div>
      </div>

      <div style={{ display: 'flex', justifyContent: 'center', gap: '10px' }}>
        <button 
          onClick={highlightNextBox}
          style={{
            padding: '10px 20px',
            fontSize: '16px',
            backgroundColor: '#000000ff',
            color: 'white',
            border: 'none',
            borderRadius: '5px',
            cursor: 'pointer'
          }}
        >
          Highlight Next Box
        </button>
      </div>
    </div>
  );
}
