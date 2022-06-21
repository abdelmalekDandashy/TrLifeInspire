const INITIAL_STATE = {
  allTrips: [],
  error: false,
};

export default function (state = INITIAL_STATE, action) {
  console.log(action.payload);
  switch (action.type) {
    case "GET_ALL_TRIPS":
      return {
        ...state,
        allTrips: action.payload.Trips,
        error: action.payload.error,
      };
    default:
      return state;
  }
}
