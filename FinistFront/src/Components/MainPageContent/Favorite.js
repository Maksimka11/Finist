import { React, useEffect } from 'react';
import { useDispatch, useSelector } from 'react-redux';
import { getFavorites } from '../../HttpRequest';
import { setFavoritesAction } from '../../Redux/Reducers/FavoriteReducer';

export default function Favorite() {
    const favorites = useSelector(state => state.Favorite.favorites);
    const account = useSelector(state => state.BankAccount.account);
    const dispatch = useDispatch();
    useEffect(() => {
        if (account != null) {
            if ( favorites == null) {
                getFavorites(account.id)
                .then ((res) => {
                    dispatch(setFavoritesAction(res));
                })
            }
        }
    },[account])

    return(
        <div className='container '>
            <p>ИЗБРАННОЕ</p>
            <div className='d-flex flex-wrap'>
                {favorites?.map((el, id) => {
                    return (
                        <div className='text-center mx-3' key={id}>
                            <img alt='Фото' src={require("../../Images/AccountImages/" + el.image)} height={50} width={50}/>
                            <p><b>{el.name}</b></p>
                        </div>
                    )
                })

                }
            </div>
        </div>
    )
}