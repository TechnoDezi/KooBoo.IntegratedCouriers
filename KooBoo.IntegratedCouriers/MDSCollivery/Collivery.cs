using KooBoo.IntegratedCouriers.Helpers;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace KooBoo.IntegratedCouriers.MDSCollivery
{
    public class Collivery
    {
        private string _baseAddress = "https://www.collivery.co.za/api/";

        public string BaseAddress
        {
            get
            {
                return _baseAddress;
            }
            set 
            {
                _baseAddress = value;
            }
        }

        public AuthenticateRequest auth { get; set; }

        /// <summary>
        /// Authenticate using your account email and password. It is recommended that you create a new user on your account that will be used with the web service only. Use this username (email) and password to authenticate so you can distinguish between Colliveries added by the web service and those added manually. You can do this using the User Admin tool in quote.collivery.co.za. Please note that all correspondence for these Colliveries goes to this email address, so make sure it's a valid email that someone reads often. Once authenticated, store the returned token in a session and use that token on every query. Tokens expire after 1 hour of inactivity. 
        /// </summary>
        /// <returns></returns>
        public async Task<AuthenticateResponse> authenticate()
        {
            AuthenticateResponse response = new AuthenticateResponse();

            HttpClient client = HelperFunctions.GetJSonHttpClient(_baseAddress);

            HttpResponseMessage responseMsg = await client.PostAsJsonAsync("authenticate", auth);
            if (responseMsg.IsSuccessStatusCode)
            {
                string content = await responseMsg.Content.ReadAsStringAsync();

                try
                {
                    response = JsonConvert.DeserializeObject<AuthenticateResponse>(content);

                    auth.old_token = response.token;
                }
                catch (Exception ex)
                {
                    response.error = JsonConvert.DeserializeObject<ColliveryError>(content);
                }                
            }
            else if (responseMsg.StatusCode == System.Net.HttpStatusCode.BadRequest)
            {
                response.error = await responseMsg.Content.ReadAsAsync<ColliveryError>();
            }

            return response;
        }

        /// <summary>
        /// Returns a list of towns and their ID's for creating new addresses. Town can be filtered by country or province (ZAF Only). 
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public async Task<GetTownsResponse> get_towns(GetTownsRequest request)
        {
            GetTownsResponse response = new GetTownsResponse();

            if (auth.old_token != "")
            {
                HttpClient client = HelperFunctions.GetJSonHttpClient(_baseAddress);

                HttpResponseMessage responseMsg = await client.PostAsJsonAsync("get_towns", request);
                if (responseMsg.IsSuccessStatusCode)
                {
                    string content = await responseMsg.Content.ReadAsStringAsync();

                    try
                    {
                        response = JsonConvert.DeserializeObject<GetTownsResponse>(content);
                    }
                    catch (Exception ex)
                    {
                        response.error = JsonConvert.DeserializeObject<ColliveryError>(content);
                    }                  
                }
                else if (responseMsg.StatusCode == System.Net.HttpStatusCode.BadRequest)
                {
                    response.error = await responseMsg.Content.ReadAsAsync<ColliveryError>();
                }
            }

            return response;
        }

        /// <summary>
        /// Allows you to search for town and suburb names starting with the given string. The minimum string length to search is two characters. Returns a list of towns, suburbs, and the towns the suburbs belong to with their ID's for creating new addresses. The idea is that this could be used in an auto complete function. 
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public async Task<SearchTownsResponse> search_towns(SearchTownsRequest request)
        {
            SearchTownsResponse response = new SearchTownsResponse();

            if (auth.old_token != "")
            {
                HttpClient client = HelperFunctions.GetJSonHttpClient(_baseAddress);

                HttpResponseMessage responseMsg = await client.PostAsJsonAsync("search_towns", request);
                if (responseMsg.IsSuccessStatusCode)
                {
                    string content = await responseMsg.Content.ReadAsStringAsync();

                    try
                    {
                        response = JsonConvert.DeserializeObject<SearchTownsResponse>(content);
                    }
                    catch (Exception ex)
                    {
                        response.error = JsonConvert.DeserializeObject<ColliveryError>(content);
                    }
                }
                else if (responseMsg.StatusCode == System.Net.HttpStatusCode.BadRequest)
                {
                    response.error = await responseMsg.Content.ReadAsAsync<ColliveryError>();
                }
            }

            return response;
        }

        /// <summary>
        /// Returns all the suburbs of a specific town and their ID's. Use this ID when creating a new address. Some towns only have a single suburb "CBD". This is mainly because the town is small enough to not require any additional information. 
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public async Task<GetSuburbsResponse> get_suburbs(GetSuburbsRequest request)
        {
            GetSuburbsResponse response = new GetSuburbsResponse();

            if (auth.old_token != "")
            {
                HttpClient client = HelperFunctions.GetJSonHttpClient(_baseAddress);

                HttpResponseMessage responseMsg = await client.PostAsJsonAsync("get_suburbs", request);
                if (responseMsg.IsSuccessStatusCode)
                {
                    string content = await responseMsg.Content.ReadAsStringAsync();

                    try
                    {
                        response = JsonConvert.DeserializeObject<GetSuburbsResponse>(content);
                    }
                    catch (Exception ex)
                    {
                        response.error = JsonConvert.DeserializeObject<ColliveryError>(content);
                    }
                }
                else if (responseMsg.StatusCode == System.Net.HttpStatusCode.BadRequest)
                {
                    response.error = await responseMsg.Content.ReadAsAsync<ColliveryError>();
                }
            }

            return response;
        }

        /// <summary>
        /// Returns the different location types (Private House, Business Premises, Mine) and their ID. This is important when you need an accurate price as some location types may incur a surcharge due to time spent during the delivery. 
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public async Task<GetLocationTypesResponse> get_location_types(GetLocationTypesRequest request)
        {
            GetLocationTypesResponse response = new GetLocationTypesResponse();

            if (auth.old_token != "")
            {
                HttpClient client = HelperFunctions.GetJSonHttpClient(_baseAddress);

                HttpResponseMessage responseMsg = await client.PostAsJsonAsync("get_location_types", request);
                if (responseMsg.IsSuccessStatusCode)
                {
                    string content = await responseMsg.Content.ReadAsStringAsync();

                    try
                    {
                        response = JsonConvert.DeserializeObject<GetLocationTypesResponse>(content);
                    }
                    catch (Exception ex)
                    {
                        response.error = JsonConvert.DeserializeObject<ColliveryError>(content);
                    }
                }
                else if (responseMsg.StatusCode == System.Net.HttpStatusCode.BadRequest)
                {
                    response.error = await responseMsg.Content.ReadAsAsync<ColliveryError>();
                }
            }

            return response;
        }

        /// <summary>
        /// Returns an array of the available Collivery Service Types. 
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public async Task<GetServicesResponse> get_services(GetServicesRequest request)
        {
            GetServicesResponse response = new GetServicesResponse();

            if (auth.old_token != "")
            {
                HttpClient client = HelperFunctions.GetJSonHttpClient(_baseAddress);

                HttpResponseMessage responseMsg = await client.PostAsJsonAsync("get_services", request);
                if (responseMsg.IsSuccessStatusCode)
                {
                    string content = await responseMsg.Content.ReadAsStringAsync();

                    try
                    {
                        response = JsonConvert.DeserializeObject<GetServicesResponse>(content);
                    }
                    catch (Exception ex)
                    {
                        response.error = JsonConvert.DeserializeObject<ColliveryError>(content);
                    }
                }
                else if (responseMsg.StatusCode == System.Net.HttpStatusCode.BadRequest)
                {
                    response.error = await responseMsg.Content.ReadAsAsync<ColliveryError>();
                }
            }

            return response;
        }

        /// <summary>
        /// Returns all the information of a single address ID. 
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public async Task<GetAddressResponse> get_address(GetAddressRequest request)
        {
            GetAddressResponse response = new GetAddressResponse();

            if (auth.old_token != "")
            {
                HttpClient client = HelperFunctions.GetJSonHttpClient(_baseAddress);

                HttpResponseMessage responseMsg = await client.PostAsJsonAsync("get_address", request);
                if (responseMsg.IsSuccessStatusCode)
                {
                    string content = await responseMsg.Content.ReadAsStringAsync();

                    try
                    {
                        response = JsonConvert.DeserializeObject<GetAddressResponse>(content);
                    }
                    catch (Exception ex)
                    {
                        response.error = JsonConvert.DeserializeObject<ColliveryError>(content);
                    }
                }
                else if (responseMsg.StatusCode == System.Net.HttpStatusCode.BadRequest)
                {
                    response.error = await responseMsg.Content.ReadAsAsync<ColliveryError>();
                }
            }

            return response;
        }

        /// <summary>
        /// Returns all the addresses belonging to a client and their Information. 
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public async Task<GetAddressesResponse> get_addresses(GetAddressesRequest request)
        {
            GetAddressesResponse response = new GetAddressesResponse();

            if (auth.old_token != "")
            {
                HttpClient client = HelperFunctions.GetJSonHttpClient(_baseAddress);

                HttpResponseMessage responseMsg = await client.PostAsJsonAsync("get_addresses", request);
                if (responseMsg.IsSuccessStatusCode)
                {
                    string content = await responseMsg.Content.ReadAsStringAsync();

                    try
                    {
                        response = JsonConvert.DeserializeObject<GetAddressesResponse>(content);
                    }
                    catch (Exception ex)
                    {
                        response.error = JsonConvert.DeserializeObject<ColliveryError>(content);
                    }
                }
                else if (responseMsg.StatusCode == System.Net.HttpStatusCode.BadRequest)
                {
                    response.error = await responseMsg.Content.ReadAsAsync<ColliveryError>();
                }
            }

            return response;
        }

        /// <summary>
        /// Returns all the contacts belonging to a spesific address. 
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public async Task<GetContactsResponse> get_contacts(GetContactsRequest request)
        {
            GetContactsResponse response = new GetContactsResponse();

            if (auth.old_token != "")
            {
                HttpClient client = HelperFunctions.GetJSonHttpClient(_baseAddress);

                HttpResponseMessage responseMsg = await client.PostAsJsonAsync("get_contacts", request);
                if (responseMsg.IsSuccessStatusCode)
                {
                    string content = await responseMsg.Content.ReadAsStringAsync();

                    try
                    {
                        response = JsonConvert.DeserializeObject<GetContactsResponse>(content);
                    }
                    catch (Exception ex)
                    {
                        response.error = JsonConvert.DeserializeObject<ColliveryError>(content);
                    }
                }
                else if (responseMsg.StatusCode == System.Net.HttpStatusCode.BadRequest)
                {
                    response.error = await responseMsg.Content.ReadAsAsync<ColliveryError>();
                }
            }

            return response;
        }

        /// <summary>
        /// Adds a new address to the your account on the Collivery system. 
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public async Task<AddAddressResponse> add_address(AddAddressRequest request)
        {
            AddAddressResponse response = new AddAddressResponse();

            if (auth.old_token != "")
            {
                HttpClient client = HelperFunctions.GetJSonHttpClient(_baseAddress);

                HttpResponseMessage responseMsg = await client.PostAsJsonAsync("add_address", request);
                if (responseMsg.IsSuccessStatusCode)
                {
                    string content = await responseMsg.Content.ReadAsStringAsync();

                    try
                    {
                        response = JsonConvert.DeserializeObject<AddAddressResponse>(content);
                    }
                    catch (Exception ex)
                    {
                        response.error = JsonConvert.DeserializeObject<ColliveryError>(content);
                    }
                }
                else if (responseMsg.StatusCode == System.Net.HttpStatusCode.BadRequest)
                {
                    response.error = await responseMsg.Content.ReadAsAsync<ColliveryError>();
                }
            }

            return response;
        }

        /// <summary>
        /// Adds a contact for the address
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public async Task<AddContactResponse> add_contact(AddContactRequest request)
        {
            AddContactResponse response = new AddContactResponse();

            if (auth.old_token != "")
            {
                HttpClient client = HelperFunctions.GetJSonHttpClient(_baseAddress);

                HttpResponseMessage responseMsg = await client.PostAsJsonAsync("add_contact", request);
                if (responseMsg.IsSuccessStatusCode)
                {
                    string content = await responseMsg.Content.ReadAsStringAsync();

                    try
                    {
                        response = JsonConvert.DeserializeObject<AddContactResponse>(content);
                    }
                    catch (Exception ex)
                    {
                        response.error = JsonConvert.DeserializeObject<ColliveryError>(content);
                    }
                }
                else if (responseMsg.StatusCode == System.Net.HttpStatusCode.BadRequest)
                {
                    response.error = await responseMsg.Content.ReadAsAsync<ColliveryError>();
                }
            }

            return response;
        }

        /// <summary>
        /// Returns the POD image for a given Waybill Number. 
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public async Task<GetProofOfDeliveryResponse> get_pod(GetProofOfDeliveryRequest request)
        {
            GetProofOfDeliveryResponse response = new GetProofOfDeliveryResponse();

            if (auth.old_token != "")
            {
                HttpClient client = HelperFunctions.GetJSonHttpClient(_baseAddress);

                HttpResponseMessage responseMsg = await client.PostAsJsonAsync("get_pod", request);
                if (responseMsg.IsSuccessStatusCode)
                {
                    string content = await responseMsg.Content.ReadAsStringAsync();

                    try
                    {
                        response = JsonConvert.DeserializeObject<GetProofOfDeliveryResponse>(content);
                    }
                    catch (Exception ex)
                    {
                        response.error = JsonConvert.DeserializeObject<ColliveryError>(content);
                    }
                }
                else if (responseMsg.StatusCode == System.Net.HttpStatusCode.BadRequest)
                {
                    response.error = await responseMsg.Content.ReadAsAsync<ColliveryError>();
                }
            }

            return response;
        }

        /// <summary>
        /// Returns a list of available parcel images and their info for a given Waybill Number. 
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public async Task<GetParcelImagesResponse> get_parcel_image_list(GetParcelImagesRequest request)
        {
            GetParcelImagesResponse response = new GetParcelImagesResponse();

            if (auth.old_token != "")
            {
                HttpClient client = HelperFunctions.GetJSonHttpClient(_baseAddress);

                HttpResponseMessage responseMsg = await client.PostAsJsonAsync("get_parcel_image_list", request);
                if (responseMsg.IsSuccessStatusCode)
                {
                    string content = await responseMsg.Content.ReadAsStringAsync();

                    try
                    {
                        response = JsonConvert.DeserializeObject<GetParcelImagesResponse>(content);
                    }
                    catch (Exception ex)
                    {
                        response.error = JsonConvert.DeserializeObject<ColliveryError>(content);
                    }
                }
                else if (responseMsg.StatusCode == System.Net.HttpStatusCode.BadRequest)
                {
                    response.error = await responseMsg.Content.ReadAsAsync<ColliveryError>();
                }
            }

            return response;
        }

        /// <summary>
        /// Returns a image encoded in BASE 64 and its information for a given parcel ID. 
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public async Task<GetParcelImageResponse> get_parcel_image(GetParcelImageRequest request)
        {
            GetParcelImageResponse response = new GetParcelImageResponse();

            if (auth.old_token != "")
            {
                HttpClient client = HelperFunctions.GetJSonHttpClient(_baseAddress);

                HttpResponseMessage responseMsg = await client.PostAsJsonAsync("get_parcel_image", request);
                if (responseMsg.IsSuccessStatusCode)
                {
                    string content = await responseMsg.Content.ReadAsStringAsync();

                    try
                    {
                        response = JsonConvert.DeserializeObject<GetParcelImageResponse>(content);
                    }
                    catch (Exception ex)
                    {
                        response.error = JsonConvert.DeserializeObject<ColliveryError>(content);
                    }
                }
                else if (responseMsg.StatusCode == System.Net.HttpStatusCode.BadRequest)
                {
                    response.error = await responseMsg.Content.ReadAsAsync<ColliveryError>();
                }
            }

            return response;
        }

        /// <summary>
        /// Returns the status tracking detail of a given Waybill number. If the Collivery is still active, the estimated time of delivery will be provided. If delivered, the time and receivers name (if available) is returned. 
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public async Task<GetColliveryStatusResponse> get_collivery_status(GetColliveryStatusRequest request)
        {
            GetColliveryStatusResponse response = new GetColliveryStatusResponse();

            if (auth.old_token != "")
            {
                HttpClient client = HelperFunctions.GetJSonHttpClient(_baseAddress);

                HttpResponseMessage responseMsg = await client.PostAsJsonAsync("get_collivery_status", request);
                if (responseMsg.IsSuccessStatusCode)
                {
                    string content = await responseMsg.Content.ReadAsStringAsync();

                    try
                    {
                        response.status = JsonConvert.DeserializeObject<ColliveryStatus>(content);
                    }
                    catch (Exception ex)
                    {
                        response.error = JsonConvert.DeserializeObject<ColliveryError>(content);
                    }
                }
                else if (responseMsg.StatusCode == System.Net.HttpStatusCode.BadRequest)
                {
                    response.error = await responseMsg.Content.ReadAsAsync<ColliveryError>();
                }
            }

            return response;
        }

        /// <summary>
        /// Returns the available Parcel Type ID and value array for use in adding a Collivery. 
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public async Task<GetParcelTypesResponse> get_parcel_types(GetParcelTypesRequest request)
        {
            GetParcelTypesResponse response = new GetParcelTypesResponse();

            if (auth.old_token != "")
            {
                HttpClient client = HelperFunctions.GetJSonHttpClient(_baseAddress);

                HttpResponseMessage responseMsg = await client.PostAsJsonAsync("get_parcel_types", request);
                if (responseMsg.IsSuccessStatusCode)
                {
                    string content = await responseMsg.Content.ReadAsStringAsync();

                    try
                    {
                        var roles = JsonConvert.DeserializeObject<JObject>(content);

                        response.parcelTypes = new List<ParcelType>();

                        foreach (JProperty property in roles.Properties())
                        {
                            int parcelID = int.Parse(property.Name);

                            var parcelType = property.Value.ToObject<ParcelType>();
                            parcelType.parcel_type_id = parcelID;
                            response.parcelTypes.Add(parcelType);
                        }
                    }
                    catch (Exception ex)
                    {
                        response.error = JsonConvert.DeserializeObject<ColliveryError>(content);
                    }
                }
                else if (responseMsg.StatusCode == System.Net.HttpStatusCode.BadRequest)
                {
                    response.error = await responseMsg.Content.ReadAsAsync<ColliveryError>();
                }
            }

            return response;
        }

        /// <summary>
        /// Returns an price for the current delivery. Very similar to the Validate Function, however, address ID, and Contact ID can be replaced with Town ID and Location Type. Although this method is extremely accurate, it isn't as accurate as the Validate function as time surcharges aren't calculated (Weekends, Holidays and After Hour Colliveries) 
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public async Task<GetPriceResponse> get_price(GetPriceRequest request)
        {
            GetPriceResponse response = new GetPriceResponse();

            if (auth.old_token != "")
            {
                HttpClient client = HelperFunctions.GetJSonHttpClient(_baseAddress);

                HttpResponseMessage responseMsg = await client.PostAsJsonAsync("get_price", request);
                if (responseMsg.IsSuccessStatusCode)
                {
                    string content = await responseMsg.Content.ReadAsStringAsync();

                    try
                    {
                        response = JsonConvert.DeserializeObject<GetPriceResponse>(content);
                    }
                    catch (Exception ex)
                    {
                        response.error = JsonConvert.DeserializeObject<ColliveryError>(content);
                    }
                }
                else if (responseMsg.StatusCode == System.Net.HttpStatusCode.BadRequest)
                {
                    response.error = await responseMsg.Content.ReadAsAsync<ColliveryError>();
                }
            }

            return response;
        }

        /// <summary>
        /// Returns the validated data array of all details pertaining to a Collivery. This process validates the information based on services, time frames and parcel information. Dates and times may be altered during this process based on the collection and delivery towns service parameters. Certain towns are only serviced on specific days and between certain times. This function automatically alters the values. The parcels volumetric calculations are also done at this time. It is important that the data is first validated before a Collivery can be added. 
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public async Task<ValidateColliveryResponse> validate_collivery(ValidateColliveryRequest request)
        {
            ValidateColliveryResponse response = new ValidateColliveryResponse();

            if (auth.old_token != "")
            {
                HttpClient client = HelperFunctions.GetJSonHttpClient(_baseAddress);

                HttpResponseMessage responseMsg = await client.PostAsJsonAsync("validate_collivery", request);
                if (responseMsg.IsSuccessStatusCode)
                {
                    string content = await responseMsg.Content.ReadAsStringAsync();

                    try
                    {
                        response = JsonConvert.DeserializeObject<ValidateColliveryResponse>(content);
                    }
                    catch (Exception ex)
                    {
                        response.error = JsonConvert.DeserializeObject<ColliveryError>(content);
                    }
                }
                else if (responseMsg.StatusCode == System.Net.HttpStatusCode.BadRequest)
                {
                    response.error = await responseMsg.Content.ReadAsAsync<ColliveryError>();
                }
            }

            return response;
        }

        /// <summary>
        /// Creates a new Collivery based on the data array provided. The array should first be validated before passing to this function. The Waybill No is return upon successful creation of the Collivery. 
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public async Task<AddColliveryResponse> add_collivery(AddColliveryRequest request)
        {
            AddColliveryResponse response = new AddColliveryResponse();

            if (auth.old_token != "")
            {
                HttpClient client = HelperFunctions.GetJSonHttpClient(_baseAddress);

                HttpResponseMessage responseMsg = await client.PostAsJsonAsync("add_collivery", request);
                if (responseMsg.IsSuccessStatusCode)
                {
                    string content = await responseMsg.Content.ReadAsStringAsync();

                    try
                    {
                        response = JsonConvert.DeserializeObject<AddColliveryResponse>(content);
                    }
                    catch (Exception ex)
                    {
                        response.error = JsonConvert.DeserializeObject<ColliveryError>(content);
                    }
                }
                else if (responseMsg.StatusCode == System.Net.HttpStatusCode.BadRequest)
                {
                    response.error = await responseMsg.Content.ReadAsAsync<ColliveryError>();
                }
            }

            return response;
        }

        /// <summary>
        /// Processes the newly created Collivery from Waiting Acceptance to Accepted. You may optionally choose to have the standard email notifications sent out at this time. 
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public async Task<AcceptColliveryResponse> accept_collivery(AcceptColliveryRequest request)
        {
            AcceptColliveryResponse response = new AcceptColliveryResponse();

            if (auth.old_token != "")
            {
                HttpClient client = HelperFunctions.GetJSonHttpClient(_baseAddress);

                HttpResponseMessage responseMsg = await client.PostAsJsonAsync("accept_collivery", request);
                if (responseMsg.IsSuccessStatusCode)
                {
                    string content = await responseMsg.Content.ReadAsStringAsync();

                    try
                    {
                        response = JsonConvert.DeserializeObject<AcceptColliveryResponse>(content);
                    }
                    catch (Exception ex)
                    {
                        response.error = JsonConvert.DeserializeObject<ColliveryError>(content);
                    }
                }
                else if (responseMsg.StatusCode == System.Net.HttpStatusCode.BadRequest)
                {
                    response.error = await responseMsg.Content.ReadAsAsync<ColliveryError>();
                }
            }

            return response;
        }

        /// <summary>
        /// Cancels a Collivery.
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public async Task<CancelColliveryResponse> cancel_collivery(CancelColliveryRequest request)
        {
            CancelColliveryResponse response = new CancelColliveryResponse();

            if (auth.old_token != "")
            {
                HttpClient client = HelperFunctions.GetJSonHttpClient(_baseAddress);

                HttpResponseMessage responseMsg = await client.PostAsJsonAsync("cancel_collivery", request);
                if (responseMsg.IsSuccessStatusCode)
                {
                    string content = await responseMsg.Content.ReadAsStringAsync();

                    try
                    {
                        response = JsonConvert.DeserializeObject<CancelColliveryResponse>(content);
                    }
                    catch (Exception ex)
                    {
                        response.error = JsonConvert.DeserializeObject<ColliveryError>(content);
                    }
                }
                else if (responseMsg.StatusCode == System.Net.HttpStatusCode.BadRequest)
                {
                    response.error = await responseMsg.Content.ReadAsAsync<ColliveryError>();
                }
            }

            return response;
        }
    }
}
