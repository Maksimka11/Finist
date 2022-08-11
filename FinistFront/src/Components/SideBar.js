import {React, useEffect, useState} from "react";
import {useDispatch, useSelector} from "react-redux";
import { getCreditCards, getDebetCards } from "../HttpRequest";
import { setCreditAction, setDebetAction } from "../Redux/Reducers/CardReducer";
export default function Sidebar() {
    const BankAccount = useSelector(state => state.BankAccount.account); 
    const debetCards = useSelector(state => state.Card.debet);
    const creditCards = useSelector(state => state.Card.credit);
    const [creditBalance, setCreditBalance] = useState(0);
    const [debetBalance, setDebetBalance] = useState(0);
    const dispatch = useDispatch();
    useEffect(() => {
        if(BankAccount != null) {
            getCreditCards(BankAccount?.id)
            .then((res)=> {
                dispatch(setCreditAction(res));
            })
            getDebetCards(BankAccount?.id)
            .then((res) => {
                dispatch(setDebetAction(res));
            })
        }
    }, [BankAccount])

    useEffect(() => {
        let balance = 0
        creditCards?.forEach(element => {
            balance += element.balance;
        });
        setCreditBalance(balance);        
    },[creditCards])

    useEffect(() => {
        let balance = 0;
        debetCards?.forEach(element => {
            balance += element.balance;
        });
        setDebetBalance(balance);
    },[debetCards])


    return (
        <div className="flex-shrink-0 p-3 border-end" style={{width: "280px", height: outerHeight}}>
            <h5>Счета и карты</h5>
            <div>            
                <div className="row">
                    <div className="col">
                    <img width={50} height={50} src={require("../Images/credit.png")}/>
                    </div>
                    <div className="col-8">
                        <b>Мои карты</b>
                        <p>{debetBalance.toFixed(2)}₽</p>
                    </div>
                </div>
                <ul className="list-unstyled ps-0">
                    {debetCards?.map((dc, id) => {
                        return(
                        <li className="text-center" key={id}>
                            <div className="row align-items-center">
                                <div className="col">
                                    <img src={require("../Images/turn-down.png")} height={30} width={30} />
                                </div>
                                <div className="col">
                                    <h5 className="text-muted">{dc.balance.toFixed(2)}₽</h5>
                                </div>
                                <div className="col">                                
                                    <img width={50} height={50} src={require("../Images/CardImages/" + dc.cardPhoto)}/>
                                </div>                        
                            </div>
                        </li>
                        )
                    })
                    }
                </ul>       
            </div>

            <div>
                <div className="row">
                    <div className="col">
                    <img width={50} height={50} src={require("../Images/credit.png")}/>
                    </div>
                    <div className="col-8">
                        <b>Кредитные карты</b>
                        <p>{creditBalance.toFixed(2)}₽</p>
                    </div>
                </div>
                <ul className="list-unstyled ps-0">
                    {creditCards?.map((cc, id) => {
                        return(
                        <li className="text-center" key={id}>
                            <div className="row align-items-center">
                                <div className="col">
                                    <img src={require("../Images/turn-down.png")} height={30} width={30} />
                                </div>
                                <div className="col">
                                    <h5 className="text-muted">{cc.balance.toFixed(2)}₽</h5>
                                </div>
                                <div className="col">                                
                                    <img width={50} height={50} src={require("../Images/CardImages/" + cc.cardPhoto)}/>
                                </div>                                
                            </div>
                        </li>
                        )
                    })
                    }
                </ul>       
            </div>
            
        </div>       
    )
}