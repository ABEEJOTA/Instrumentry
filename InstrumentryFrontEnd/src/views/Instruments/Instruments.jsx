import axios from "axios";
import { useState, useEffect } from "react";
import "../../App.css";
import BasicGrid from "../../components/BasicGrid/BasicGrid.jsx";
import BasicFlex from "../../components/BasicFlex/BasicFlex.jsx";

//MAIN
export default function Instruments() {
  //useStates
  const [instrument, setInstrument] = useState([]);
  //hooks

  //funciones
  function GetInstrumentData() {
    axios.
    get("https://localhost:7124/Instrumentry").
    then((response) => setInstrument(response.data));
  }

  //useEffects
  useEffect(()=>{
    // debugger
    console.log(instrument);
  },[instrument]);

  useEffect(() => {
    GetInstrumentData();
  },[]);


  return (
    <>
      <BasicFlex instrument={instrument} />
    </>
  );
}
