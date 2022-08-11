const defaultState = {
    user: null
}
const setUser = "setUser";

export const setUserAction = (value) => {
    return {type: setUser, value: value}
}

 
export  const UserReducer = (state = defaultState, action = {type: "", value: ""}) => {
    switch (action.type) {
        case setUser:
            return {...state, user: action.value}
        default:
            return state
    }
}