import React,{useContext} from 'react'
import {Context} from '../../Store'
import BlagajnikTroskovi from './blagajnikTroskovi'
import MojiRacuni from './mojiRacuni'

export default function StatusTroskova() {
    const [state, dispatch] = useContext(Context);
    const isBlagajnik=state.stanar.status==='blagajnik'?true:state.stanar.status==='admin'?true:false;

    const prikazi=()=>{
        return isBlagajnik?<BlagajnikTroskovi />:<MojiRacuni />
    }
    return prikazi();
}
