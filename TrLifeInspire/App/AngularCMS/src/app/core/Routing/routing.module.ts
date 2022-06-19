import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { LoginComponent } from '../../components/login/login.component';
import { LogoutComponent } from '../../components/logout/logout.component';
import { CanActivateThisRoute } from '../Guard/RouterGuard';
import { MenuComponent } from '../../components/menu/menu.component';
import { TripComponent } from '../../components/Trip/trip.component';
import { StaffComponent } from '../../components/Staff/staff.component';
import { Social_media_linksComponent } from '../../components/Social_media_links/social_media_links.component';
import { IncludesComponent } from '../../components/Includes/includes.component';
import { FeaturesComponent } from '../../components/Features/features.component';


export const routes: Routes = [
  { path: 'login', component: LoginComponent },
  { path: 'logout', component: LogoutComponent },
  { path: 'trip', component: TripComponent },
  { path: 'Features', component: FeaturesComponent },
  { path: 'Inludes', component: IncludesComponent },
  { path: 'Social', component: Social_media_linksComponent },
  { path: 'Staff', component: StaffComponent },
  { path: 'menu', component: MenuComponent, canActivate: [CanActivateThisRoute] },
  { path: '**', component: LoginComponent },
];


@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class RoutingModule { }
