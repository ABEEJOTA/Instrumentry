import * as React from 'react';
import "./BasicFlex.css";
import BasicModal from '../BasicModal/basicModal';

export default function BasicFlex(props) {

    const {instrument} = props;
    console.log(instrument);
  
    return (
      <div className="container">
        <div className="flex">
        {instrument.map((instrument, index) => (
          <BasicModal instrument={instrument} index = {index}></BasicModal>
        ))}
        </div>
      </div>
    );
  }

/*
  return (
    <div className="container">
      <div className="flex">
      {instrument.map((instrument, index) => (
            <div className="item-container" key={index}>
              <div className="item">
                <div className="container-img">
                    <img src={instrument.image}/>
                </div>
                <p>{instrument.model}<br/></p>
                <p>{instrument.brand}</p>
              </div>
              <BasicModal></BasicModal>
            </div>
      ))}
      </div>
    </div>
  );
*/