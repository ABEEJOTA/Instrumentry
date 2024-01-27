import axios from "axios";
import { useState, useEffect } from "react";
import "../../App.css";
import BasicModal from "../../components/BasicModal/basicModal.jsx";
import "./Instruments.css"

//MAIN
export default function Instruments() {
  //useStates
  const [instrument, setInstrument] = useState([]);
  //hooks

  //funciones
  function GetInstrumentData() {
    axios.
    get("https://localhost:7124/api/Instruments/GetInstrumentryBasicDTO").
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
      <div className="container">
        <div className="flex">
        {instrument.map((instrument, index) => (
          <BasicModal 
            instrument={instrument}
            key={index}>
          </BasicModal>
        ))}
        </div>
      </div>
    </>
  );
}
