import {configureStore} from "@reduxjs/toolkit"
import { UserReducer } from "./Reducers/UserReducer";
import { combineReducers } from "redux";
import { BankAccountReducer } from "./Reducers/BankAccountReducer";
import { FavoritesReducer } from "./Reducers/FavoriteReducer";
import { CardReducer } from "./Reducers/CardReducer";
import { TransactionReducer } from "./Reducers/TransactionReducer";

const rootReducer = combineReducers({
    BankAccount: BankAccountReducer,
    User: UserReducer,
    Favorite: FavoritesReducer,
    Card: CardReducer,
    Transaction: TransactionReducer,
})

export const store = configureStore({reducer: rootReducer});