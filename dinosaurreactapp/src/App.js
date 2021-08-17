import { useState, useEffect } from 'react';
import axios from 'axios';

function App() {
  const [dinoName, setDinoName] = useState('');

  const handleChange = (e) => {
    setDinoName(e.target.value);
  };

  const handleSubmit = async (e) => {
    e.preventDefault();

    const response = await axios.post(
      'https://localhost:5001/api/Dino/GenerateDinosaurWithDatabasev1',
      dinoName
    );
    const data = await response.json();
  };

  // useEffect( () => {

  // }, [])

  return (
    <div className="App">
      <form onSubmit={handleSubmit}>
        <input type="text" onChange={handleChange} />
        <button>Submit</button>
      </form>
    </div>
  );
}

export default App;
