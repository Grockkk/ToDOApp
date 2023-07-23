//import Show from './Show';
//import axios from "axios";
//import { useEffect, useState } from "react";
import {  useNavigate } from 'react-router-dom';

function Show(){
    const navigate = useNavigate();

    const handleClick=()=>{
        //navigating to Home 
        navigate('/ToDoCrud')
      }

    return(
        <button onClick={handleClick}>Go back</button>
    )

}

export default Show
