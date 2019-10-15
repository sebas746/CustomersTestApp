import { State } from './state.model';

export class City {
    constructor(
        public cityId?: number,
        public cityName?: string,
        public state?: State
    ) {}
}