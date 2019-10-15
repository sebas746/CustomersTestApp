declare var data: any;

export const environment = {

  production: true,

  GetCustomers: data.basePath + '/api/Customers/',  
  GetCountries: data.basePath + '/api/Geography/GetCountries/',
  GetStates: data.basePath + '/api/Geography/GetCountryStates?countryId=',
  GetCities: data.basePath + '/api/Geography/GetStateCities?stateId=',
  CreateCustomer: data.basePath + '/api/Customers/',
};
