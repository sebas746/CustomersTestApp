export class Customer {
    constructor(
        public nit?: number,
        public fullName?: string,
        public address?: string,
        public phone?: string,
        public city?: string,
        public state?: string,
        public country?: string,
    ) {}
}