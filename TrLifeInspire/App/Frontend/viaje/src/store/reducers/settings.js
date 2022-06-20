const INITIAL_STATE = {
  rightOrLeft: 'rtl',
  language: 'en'
};

export default function (state = INITIAL_STATE, action) {
  switch (action.type) {
    case "SET_LANGUAGE":
      // console.warn(action.payload)
      return {
        ...state,
        rightOrLeft: action.payload,
      };
    default:
      return state;
  }
}
