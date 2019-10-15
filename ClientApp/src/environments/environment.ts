// This file can be replaced during build by using the `fileReplacements` array.
// `ng build --prod` replaces `environment.ts` with `environment.prod.ts`.
// The list of file replacements can be found in `angular.json`.

declare var data: any;

export const environment = {
  production: false,

  GetCustomers: data.basePath + '/api/Customers/',
  GetCountries: data.basePath + '/api/Geography/GetCountries/',
  GetStates: data.basePath + '/api/Geography/GetCountryStates?countryId=',
  GetCities: data.basePath + '/api/Geography/GetStateCities?stateId=',
  CreateCustomer: data.basePath + '/api/Customers/',
};

/*
 * For easier debugging in development mode, you can import the following file
 * to ignore zone related error stack frames such as `zone.run`, `zoneDelegate.invokeTask`.
 *
 * This import should be commented out in production mode because it will have a negative impact
 * on performance if an error is thrown.
 */
// import 'zone.js/dist/zone-error';  // Included with Angular CLI.
