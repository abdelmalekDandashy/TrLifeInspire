import React, { Component } from 'react';
import ReactDOM from 'react-dom';
import { BrowserRouter as Router, HashRouter, Route, Switch } from "react-router-dom";
import HomeV1 from './components/home-v1';
import HomeV2 from './components/home-v2';
import HomeV3 from './components/home-v3';
import AboutUs from './components/about';
import TourList from './components/tour-list';
import TourListV2 from './components/tour-list-v2';
import TourListV3 from './components/tour-list-v3';
import TourDetails from './components/tour-details';
import DestinationLIst from './components/destination-list';
import DestinationLIstV2 from './components/destination-list-v2';
import DestinationDetails from './components/destination-details';
import Gallery from './components/gallery';
import GalleryDetails from './components/gallery-details';
import Faq from './components/faq';
import Contact from './components/contact';
import Error from './components/error';
import CommingSoon from './components/comming-soon';
import UserProfile from './components/user-profile';
import Blog from './components/blog';
import BlogV2 from './components/blog-v2';
import BlogV3 from './components/blog-v3';
import BlogDetails from './components/blog-details';
import { Provider } from 'react-redux';
import store from './store';
import { toObservable } from './store';
import { useSelector, useDispatch } from "react-redux";
import * as P from "./APIs/fetch";
import * as functions from "./APIs/APIs";
import * as actions from "./store/actions/trips";

import './i18n/config';


export default function Root(props) {

	// const language = useSelector((state) => state.settings?.rightOrLeft);
	// const direction = useSelector((state) => state.settings.rightOrLeft);
	// console.log(direction)
	// store.subscribe()
	// store

	const dispatch = useDispatch();
	const [direction, setDirection] = React.useState()
	const store$ = toObservable(store);
	store$.subscribe({
		onNext: (state) =>
			state != direction ?
				setDirection(state) : null
	});
	console.log(direction)
	async function allTripsHandler(trips) {
		dispatch(actions.getAllTrips(trips));
	}
	async function getAllTrips(ownerID) {
		let oParams_Get_Trip_By_OWNER_ID = new P.Param();
		oParams_Get_Trip_By_OWNER_ID.OWNER_ID = ownerID;
		let result = await functions
			.Get_Table(oParams_Get_Trip_By_OWNER_ID, "Get_Trip_By_OWNER_ID")
			.then(async (resp) => {
				if (resp?.My_Result !== null && resp?.My_Result !== undefined) {
					return {
						trips: resp?.My_Result,
						error: false,

					};
				} else {
					return { trips: null, error: true };
				}
			});
		if (result !== null && result !== undefined) {
			allTripsHandler(result);
		}
	}


	React.useEffect(() => {
		getAllTrips(1)

	}, [])


	return (
		<Provider store={store}>
			<HashRouter basename="/" >
				<div
					dir={direction?.settings?.rightOrLeft}
				>
					<Switch>
						<Route exact path="/" component={HomeV1} />
						<Route path="/home-v2" component={HomeV2} />
						<Route path="/home-v3" component={HomeV3} />
						<Route path="/about" component={AboutUs} />
						<Route path="/tour-list" component={TourList} />
						<Route path="/tour-list-v2" component={TourListV2} />
						<Route path="/tour-list-v3" component={TourListV3} />
						<Route path="/tour-details" component={TourDetails} />
						<Route path="/destination-list" component={DestinationLIst} />
						<Route path="/destination-list-v2" component={DestinationLIstV2} />
						<Route path="/destination-details" component={DestinationDetails} />
						<Route path="/gallery" component={Gallery} />
						<Route path="/gallery-details" component={GalleryDetails} />
						<Route path="/faq" component={Faq} />
						<Route path="/contact" component={Contact} />
						<Route path="/error" component={Error} />
						<Route path="/comming-soon" component={CommingSoon} />
						<Route path="/user-profile" component={UserProfile} />
						<Route path="/blog" component={Blog} />
						<Route path="/blog-v2" component={BlogV2} />
						<Route path="/blog-v3" component={BlogV3} />
						<Route path="/blog-details" component={BlogDetails} />
					</Switch>
				</div>
			</HashRouter>
		</Provider>
	)

}




ReactDOM.render(<Root />, document.getElementById('viaje'));
