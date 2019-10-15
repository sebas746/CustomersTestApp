import { Country } from './country.model';

export class State {
    constructor(
        public stateId?: number,
        public stateCode?: string,
        public stateName?: string,
        public country?: Country
    ) {}
}