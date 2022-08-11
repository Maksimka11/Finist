import {React, useEffect} from 'react';
import { useDispatch, useSelector } from 'react-redux';
import { getTransactions } from '../../HttpRequest';
import { setTransactionAction } from '../../Redux/Reducers/TransactionReducer';

export default function Transaction() {
    const transactions = useSelector(state => state.Transaction.transactions);
    const account = useSelector(state => state.BankAccount.account);
    const dispatch = useDispatch();
    useEffect(() => {
        if (account != null) {
            if ( transactions == null) {
                getTransactions(account.id)
                .then ((res) => {
                    dispatch(setTransactionAction(res));
                })
            }            
        }
    },[account])

    const get = (el) => {
        return(
            <div className="row border-bottom text-center align-items-center" style={{height: "80px"}}>
                <div className="col">
                    <b>{el.time}</b>
                    <p className='text-muted'>{el.day}</p>
                </div>                
                <div className="col">
                    <img height={50} width={50} src={require("../../Images/CardImages/" + el.cardImage)} alt="Фото"/>                                    
                </div>
                <div className="col">
                    <b>{el.cardNumber}</b>                                    
                </div>
                <div className="col">                    
                    <b className="text-success">+{el.sum.toFixed(2)}₽</b>
                </div>
                <div className="col"></div>
                <div className="col"></div>
            </div>
        )
    }

    const send = (el) => {
        return (
            <div className="row border-bottom text-center align-items-center" style={{height: "80px"}}>
                <div className="col">
                    <b>{el.time}</b>
                    <p className='text-muted'>{el.day}</p>
                </div>
                <div className="col">                                
                    <img height={50} width={50} src={require("../../Images/AccountImages/" + el.accountImage)} alt="Фото"/>                                    
                </div>     
                <div className="col">
                    <p>{el.accountName}</p>
                </div>
                <div className="col">
                    <img height={50} width={50} src={require("../../Images/CardImages/" + el.cardImage)} alt="Фото"/>                                    
                </div>
                <div className="col">
                    <b>{el.cardNumber}</b>                                    
                </div>
                <div className="col">                    
                    <b className="text-danger">-{el.sum.toFixed(2)}₽</b>
                    <p className="text-muted">{el.specific}</p>
                </div>
            </div>
        )
    }
    
    return(
        <div className='container'>
            <p>ИСТОРИЯ ОПЕРАЦИЙ</p>
            <ul className='list-unstyled'>
                {transactions?.map((el, id) => {
                    return (
                        <li key={id}>
                        {el.receiver != account.id ?
                            send(el)
                            :
                            get(el)
                        }
                        </li>                        
                    )              
                })                    
                }
            </ul>
        </div>
    )
}