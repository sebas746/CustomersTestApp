export class Customer {
    constructor(
        public nit?: number,
        public fullName?: string,
        public address?: string,
        public phone?: string,       
        public state?: string,
        public countryId?: number,
        public stateId?: number,
        public cityId?: number,
        public creditLimit?: number
    ) {}
}