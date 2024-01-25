import { useState } from "react";
import "./App.css";
import Instruments from "./views/Instruments/Instruments.jsx"

export default function App() {
  const [count, setCount] = useState(0);

  return (<>
      <Instruments></Instruments>
    </>
  );
}
