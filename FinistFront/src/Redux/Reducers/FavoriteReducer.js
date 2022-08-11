const defaultState = {
    favorites: null
}
const setFavorites = "setFavorites";

export const setFavoritesAction = (value) => {
    return {type: setFavorites, value: value}
}

 
export  const FavoritesReducer = (state = defaultState, action = {type: "", value: ""}) => {
    switch (action.type) {
        case setFavorites:
            return {...state, favorites: action.value}
        default:
            return state
    }
}