import * as React from 'react';

export default function Item(props){
    const {image, title, subtitle} = props;

    return(
            <div className="item">
                <div className="container-img">
                    <img src={image}/>
                </div>
                <p>{subtitle}<br/></p>
                <p>{title}</p>
            </div>
    );
}