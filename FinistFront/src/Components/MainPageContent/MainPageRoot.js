import {React, useEffect} from 'react';
import { useDispatch, useSelector } from 'react-redux';
import { getBankAccount } from '../../HttpRequest';
import { setBankAccountAction } from '../../Redux/Reducers/BankAccountReducer';
import Favorite from './Favorite';
import Transaction from './Transation';

export default function MainPageRoot() {
    const account = useSelector(state => state.BankAccount.account)
    const user = useSelector(state => state.User.user);
    const dispatch = useDispatch();
    useEffect(()=> {
        if (account == null && user != null) {
            getBankAccount(user?.id)
            .then((res) => {
                dispatch(setBankAccountAction(res));
            })
        }
    }, [user])

    return(
        <div className='container'>
            <Favorite/>
            <Transaction/>
        </div>
    )
}