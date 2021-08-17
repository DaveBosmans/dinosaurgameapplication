import { useState } from 'react';
import axios from 'axios';

function App() {
  const [dinoName, setDinoName] = useState({});

  const handleChange = (e) => {
    const { name, value } = e.target;
    setDinoName({
      ...dinoName,
      [name]: value,
    });
  };

  const handleSubmit = async (e) => {
    e.preventDefault();
    const name = JSON.stringify(dinoName);
    const response = await axios.post(
      'https://localhost:5001/api/Dino/GenerateDinosaurWithDatabasev1',
      name,
      {
        headers: {
          'Content-Type': 'application/json',
        },
      }
    );
    setDinoName({ dinosaurName: '' });
  };

  return (
    <div className="App">
      <form onSubmit={handleSubmit}>
        <input type="text" onChange={handleChange} name="dinosaurName" />
        <button>Submit</button>
      </form>
    </div>
  );
}

export default App;
