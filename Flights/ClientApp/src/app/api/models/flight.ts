/* tslint:disable */
/* eslint-disable */
import { TimePlace } from './time-place';
export interface Flight {
  airline?: null | string;
  arrival?: TimePlace;
  departure?: TimePlace;
  id?: string;
  price?: null | string;
  remainingNumberOfSeats?: number;
}
