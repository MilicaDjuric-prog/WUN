import React,{useState,useEffect,useContext} from 'react'
import Predlog from './predlog'
import NoviPredlog from './predlog'
import NewPredlog from './newPrelog'
import './predlozi.scss'
import { Context } from "../../Store";


export default function Predlozi() {

    const [lista,setPredlozi]=useState(new Array());
    const [state, dispatch] = useContext(Context);
    console.log(lista);

    useEffect(() => {
        console.log("hi");
        const asyncFetch=async ()=>{
          const response1=await fetch('http://localhost:5000/WUNPredlozi/VratiPredloge');
          const listaStavki=await response1.json();
          listaStavki.map(predlog=>{predlog.datumObjave=new Date(predlog.datumObjave).toLocaleString()})
          listaStavki.reverse();
          setPredlozi(listaStavki)
    
        }

      
      
        asyncFetch();
      },[state.notifikacije] );
    return (
        <div className='predlozi'>
            <NewPredlog setState={setPredlozi} />
           <div className='predloziKont'>
                {lista.map(predlog=>{ console.log("hi");
                   
                     return(<Predlog  predlog={predlog} setPredlozi={setPredlozi}/>)
                })}
            </div>
           
            
        </div>
    )
}
