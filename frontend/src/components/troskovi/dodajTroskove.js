import React,{useState} from 'react'
import {Button} from 'react-bootstrap'

export default function DodajTroskove() {

    const [mesec,setMesec]=useState("Januar");
    const [godina,setGodina]=useState("");
    const [iznos,setIznos]=useState("");

    const dodajTroskove=async ()=>{

       const response=await fetch('http://localhost:5000/WUNTroskovi/DodajDugZaMesec',{
            method:'POST',
            credentials:'include',
            headers:{'Content-Type':'application/json'},
            body:JSON.stringify({
                godina:godina,
                mesec:mesec,
                iznos:iznos
            })

        });
        console.log(response);
        if(!response.ok)
        {
            console.log(await response.json());
           
        }
        else alert(`Uspesno ste dodali svim stabarima dug za mesec: ${mesec} ${godina}. u iznosu od: ${iznos} dinara.`)
    }

    return (
      
            <div className='dodajTroskove'>
                <h5>Dodajte dug za mesec: </h5>
                <div>
                    <label>Mesec:</label>
                    <select onChange={(e) => setMesec(e.target.value) }>
                        <option>Januar</option>
                        <option>Februar</option>
                        <option>Mart</option>
                        <option>April</option>
                        <option>Maj</option>
                        <option>Jun</option>
                        <option>Jul</option>
                        <option>Avgust</option>
                        <option>Septembar</option>
                        <option>Oktobar</option>
                        <option>Novembar</option>
                        <option>Decembar</option>
                    </select>
                </div>
                <div>
                    <label>Godina:</label>
                    <input  type='number' onChange={(e)=>setGodina(e.target.value)}></input>
                </div>
                <div>
                    <label>Iznos:</label>
                    <input  type='text' onChange={(e)=>setIznos(e.target.value)}></input>
                </div>
                <Button  className='dugme 'onClick={dodajTroskove}>Dodaj</Button>
            </div>
            
        
    )
}
