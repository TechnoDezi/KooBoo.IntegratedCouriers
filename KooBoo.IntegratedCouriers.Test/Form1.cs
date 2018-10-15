using KooBoo.IntegratedCouriers.MDSCollivery;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KooBoo.IntegratedCouriers.Test
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        AuthenticateResponse authResp = new AuthenticateResponse();

        private async void btnAuth_Click(object sender, EventArgs e)
        {
            Collivery collivery = new Collivery()
            {
                auth = new AuthenticateRequest()
                {
                    email = txtEmail.Text,
                    password = txtPassword.Text
                }
            };

            authResp = await collivery.authenticate();

            if (authResp.error != null)
            {
                txtResult.Text = "Error - " + authResp.error.error;
            }
            else
            {
                txtResult.Text = "Success - Token: " + authResp.token;
            }
        }

        private async void btnGetTowns_Click(object sender, EventArgs e)
        {
            Collivery collivery = new Collivery()
            {
                auth = new AuthenticateRequest()
                {
                    email = txtEmail.Text,
                    password = txtPassword.Text
                }
            };

            GetTownsResponse townsResp = await collivery.get_towns(new GetTownsRequest() { 
                country = "ZAF",
                province = "",
                token = authResp.token
            });

            if (townsResp.error != null)
            {
                txtResult.Text = "Error - " + townsResp.error.error;
            }
            else
            {
                txtResult.Text = "Success - Towns Returned: " + townsResp.towns.Count;
            }
        }

        private async void btnSearchTowns_Click(object sender, EventArgs e)
        {
            Collivery collivery = new Collivery()
            {
                auth = new AuthenticateRequest()
                {
                    email = txtEmail.Text,
                    password = txtPassword.Text
                }
            };

            SearchTownsResponse townsResp = await collivery.search_towns(new SearchTownsRequest()
            {
                town_name = "pretoria",
                token = authResp.token
            });

            if (townsResp.error != null)
            {
                txtResult.Text = "Error - " + townsResp.error.error;
            }
            else
            {
                txtResult.Text = "Success - Towns Returned: " + townsResp.towns.Count;
            }
        }

        private async void btnGetSuburbs_Click(object sender, EventArgs e)
        {
            Collivery collivery = new Collivery()
            {
                auth = new AuthenticateRequest()
                {
                    email = txtEmail.Text,
                    password = txtPassword.Text
                }
            };

            GetSuburbsResponse townsResp = await collivery.get_suburbs(new GetSuburbsRequest()
            {
                town_id = 248,
                token = authResp.token
            });

            if (townsResp.error != null)
            {
                txtResult.Text = "Error - " + townsResp.error.error;
            }
            else
            {
                txtResult.Text = "Success - Suburbs Returned: " + townsResp.suburbs.Count;
            }
        }

        private async void btnGetLocationTypes_Click(object sender, EventArgs e)
        {
            Collivery collivery = new Collivery()
            {
                auth = new AuthenticateRequest()
                {
                    email = txtEmail.Text,
                    password = txtPassword.Text
                }
            };

            GetLocationTypesResponse townsResp = await collivery.get_location_types(new GetLocationTypesRequest()
            {                
                token = authResp.token
            });

            if (townsResp.error != null)
            {
                txtResult.Text = "Error - " + townsResp.error.error;
            }
            else
            {
                txtResult.Text = "Success - Suburbs Returned: " + townsResp.results.Count;
            }
        }

        private async void btnGetServices_Click(object sender, EventArgs e)
        {
            Collivery collivery = new Collivery()
            {
                auth = new AuthenticateRequest()
                {
                    email = txtEmail.Text,
                    password = txtPassword.Text
                }
            };

            GetServicesResponse townsResp = await collivery.get_services(new GetServicesRequest()
            {                
                token = authResp.token
            });

            if (townsResp.error != null)
            {
                txtResult.Text = "Error - " + townsResp.error.error;
            }
            else
            {
                txtResult.Text = "Success - Services Returned: " + townsResp.services.Count;
            }
        }

        private async void btnGetAddress_Click(object sender, EventArgs e)
        {
            Collivery collivery = new Collivery()
            {
                auth = new AuthenticateRequest()
                {
                    email = txtEmail.Text,
                    password = txtPassword.Text
                }
            };

            GetAddressResponse townsResp = await collivery.get_address(new GetAddressRequest()
            {
                address_id = 920466,
                token = authResp.token
            });

            if (townsResp.error != null)
            {
                txtResult.Text = "Error - " + townsResp.error.error;
            }
            else
            {
                txtResult.Text = "Success - Address Returned: " + townsResp.address.nice_address;
            }
        }

        private async void btnGetAddresses_Click(object sender, EventArgs e)
        {
            Collivery collivery = new Collivery()
            {
                auth = new AuthenticateRequest()
                {
                    email = txtEmail.Text,
                    password = txtPassword.Text
                }
            };

            GetAddressesResponse townsResp = await collivery.get_addresses(new GetAddressesRequest()
            {
                filter = new GetAddressesRequestFilter(){
                    custom_id = "4"
                },
                token = authResp.token
            });

            if (townsResp.error != null)
            {
                txtResult.Text = "Error - " + townsResp.error.error;
            }
            else
            {
                txtResult.Text = "Success - Addresses Returned: " + townsResp.addresses.Count;
            }
        }

        private async void btnGetContacts_Click(object sender, EventArgs e)
        {
            Collivery collivery = new Collivery()
            {
                auth = new AuthenticateRequest()
                {
                    email = txtEmail.Text,
                    password = txtPassword.Text
                }
            };

            GetContactsResponse townsResp = await collivery.get_contacts(new GetContactsRequest()
            {
                address_id = 870418,
                token = authResp.token
            });

            if (townsResp.error != null)
            {
                txtResult.Text = "Error - " + townsResp.error.error;
            }
            else
            {
                txtResult.Text = "Success - Contacts Returned: " + townsResp.contacts.Count;
            }
        }

        private async void btnAddAddress_Click(object sender, EventArgs e)
        {
            Collivery collivery = new Collivery()
            {
                auth = new AuthenticateRequest()
                {
                    email = txtEmail.Text,
                    password = txtPassword.Text
                }
            };

            AddAddressResponse townsResp = await collivery.add_address(new AddAddressRequest()
            {
                data = new AddAddressRequestData(){
                    building = "KooBoo test building 1",
                    cellphone = "0836198880",
                    company_name = "KooBoo",
                    country = "ZAF",
                    custom_id = "4",
                    email = "dezi.van.vuuren@kooboo.co.za",
                    full_name = "Dezi van Vuuren",
                    location_type = 1,
                    phone = "",
                    street = "South Street",
                    suburb_id = 298,
                    town_id = 248,
                    zip_code = "0157"
                },
                token = authResp.token
            });

            if (townsResp.error != null)
            {
                txtResult.Text = "Error - " + townsResp.error.error;
            }
            else
            {
                txtResult.Text = "Success - Address Added: " + townsResp.address_id;
            }
        }

        private async void btnAddContact_Click(object sender, EventArgs e)
        {
            Collivery collivery = new Collivery()
            {
                auth = new AuthenticateRequest()
                {
                    email = txtEmail.Text,
                    password = txtPassword.Text
                }
            };

            AddContactResponse townsResp = await collivery.add_contact(new AddContactRequest()
            {
                data = new AddContactRequestData()
                {
                    address_id = 920466,
                    cellphone = "0836198880",
                    email = "dezi.van.vuuren@kooboo.co.za",
                    full_name = "Dezi van Vuuren",
                    phone = ""
                },
                token = authResp.token
            });

            if (townsResp.error != null)
            {
                txtResult.Text = "Error - " + townsResp.error.error;
            }
            else
            {
                txtResult.Text = "Success - Contact Added: " + townsResp.contact_id;
            }
        }

        private async void btnGetPOD_Click(object sender, EventArgs e)
        {
            Collivery collivery = new Collivery()
            {
                auth = new AuthenticateRequest()
                {
                    email = txtEmail.Text,
                    password = txtPassword.Text
                }
            };

            GetProofOfDeliveryResponse townsResp = await collivery.get_pod(new GetProofOfDeliveryRequest()
            {
                collivery_id = 1534213,
                token = authResp.token
            });

            if (townsResp.error != null)
            {
                txtResult.Text = "Error - " + townsResp.error.error;
            }
            else
            {
                txtResult.Text = "Success - POD Returned: " + townsResp.pod.file;
            }
        }

        private async void btnGetParcelImages_Click(object sender, EventArgs e)
        {
            Collivery collivery = new Collivery()
            {
                auth = new AuthenticateRequest()
                {
                    email = txtEmail.Text,
                    password = txtPassword.Text
                }
            };

            GetParcelImagesResponse townsResp = await collivery.get_parcel_image_list(new GetParcelImagesRequest()
            {
                collivery_id = 1534213,
                token = authResp.token
            });

            if (townsResp.error != null)
            {
                txtResult.Text = "Error - " + townsResp.error.error;
            }
            else
            {
                txtResult.Text = "Success - Images Returned: " + townsResp.images.Count;
            }
        }

        private async void btnGetParcelImage_Click(object sender, EventArgs e)
        {
            Collivery collivery = new Collivery()
            {
                auth = new AuthenticateRequest()
                {
                    email = txtEmail.Text,
                    password = txtPassword.Text
                }
            };

            GetParcelImageResponse townsResp = await collivery.get_parcel_image(new GetParcelImageRequest()
            {
                parcel_id = "1534213-1",
                token = authResp.token
            });

            if (townsResp.error != null)
            {
                txtResult.Text = "Error - " + townsResp.error.error;
            }
            else
            {
                txtResult.Text = "Success - Images Returned: " + townsResp.image.file;
            }
        }

        private async void btnGetColliveryStatus_Click(object sender, EventArgs e)
        {
            Collivery collivery = new Collivery()
            {
                auth = new AuthenticateRequest()
                {
                    email = txtEmail.Text,
                    password = txtPassword.Text
                }
            };

            GetColliveryStatusResponse townsResp = await collivery.get_collivery_status(new GetColliveryStatusRequest()
            {
                collivery_id = 1534213,
                token = authResp.token
            });

            if (townsResp.error != null)
            {
                txtResult.Text = "Error - " + townsResp.error.error;
            }
            else
            {
                txtResult.Text = "Success - Status: " + townsResp.status.status_text;
            }
        }

        private async void btnGetParcelTypes_Click(object sender, EventArgs e)
        {
            Collivery collivery = new Collivery()
            {
                auth = new AuthenticateRequest()
                {
                    email = txtEmail.Text,
                    password = txtPassword.Text
                }
            };

            GetParcelTypesResponse townsResp = await collivery.get_parcel_types(new GetParcelTypesRequest()
            {
                token = authResp.token
            });

            if (townsResp.error != null)
            {
                txtResult.Text = "Error - " + townsResp.error.error;
            }
            else
            {
                txtResult.Text = "Success - Parcel Types Returned: " + townsResp.parcelTypes.Count;
            }
        }

        private async void btnGetPrice_Click(object sender, EventArgs e)
        {
            Collivery collivery = new Collivery()
            {
                auth = new AuthenticateRequest()
                {
                    email = txtEmail.Text,
                    password = txtPassword.Text
                }
            };

            GetPriceResponse townsResp = await collivery.get_price(new GetPriceRequest()
            {
                data = new GetPriceRequestData()
                {
                    collivery_from = 920466,
                    collivery_to = 870418,
                    collivery_type = 2,
                    cover = 0,
                    exclude_weekend = 1,
                    parcel_count = 1,
                    parcels = new List<Parcel>(){
                        new Parcel()
                        {
                            height = 22,
                            length = 23,
                            weight = 1.3m,
                            width = 24
                        }
                    },
                    service = 1,
                    weight = 1.3m
                },
                token = authResp.token
            });

            if (townsResp.error != null)
            {
                txtResult.Text = "Error - " + townsResp.error.error;
            }
            else
            {
                txtResult.Text = "Success - Price Returned: " + townsResp.price.inc_vat;
            }
        }

        private async void btnValidateCollivery_Click(object sender, EventArgs e)
        {
            Collivery collivery = new Collivery()
            {
                auth = new AuthenticateRequest()
                {
                    email = txtEmail.Text,
                    password = txtPassword.Text
                }
            };

            ValidateColliveryResponse townsResp = await collivery.validate_collivery(new ValidateColliveryRequest()
            {
                data = new ValidateColliveryRequestData()
                {
                    collivery_from = 920466,
                    collivery_to = 870418,
                    collivery_type = 2,
                    cover = 0,
                    parcel_count = 1,
                    parcels = new List<Parcel>(){
                        new Parcel()
                        {
                            height = 22,
                            length = 23,
                            weight = 1.3m,
                            width = 24
                        }
                    },
                    service = 1,
                    weight = 1.3m
                },
                token = authResp.token
            });

            if (townsResp.error != null)
            {
                txtResult.Text = "Error - " + townsResp.error.error;
            }
            else
            {
                txtResult.Text = "Success - Price Returned: " + townsResp.price.inc_vat;
            }
        }

        private async void btnAddCollivery_Click(object sender, EventArgs e)
        {
            Collivery collivery = new Collivery()
            {
                auth = new AuthenticateRequest()
                {
                    email = txtEmail.Text,
                    password = txtPassword.Text
                }
            };

            ValidateColliveryResponse townsResp = await collivery.validate_collivery(new ValidateColliveryRequest()
            {
                data = new ValidateColliveryRequestData()
                {
                    collivery_from = 920466,
                    collivery_to = 870418,
                    collivery_type = 2,
                    contact_from = 951676,
                    contact_to = 900189,
                    cover = 0,
                    parcel_count = 1,
                    parcels = new List<Parcel>(){
                        new Parcel()
                        {
                            height = 22,
                            length = 23,
                            weight = 1.3m,
                            width = 24
                        }
                    },
                    service = 1,
                    weight = 1.3m
                },
                token = authResp.token
            });

            if (townsResp.error != null)
            {
                txtResult.Text = "Error - " + townsResp.error.error;
            }
            else
            {
                //After validate add collivery
                AddColliveryResponse addResp = await collivery.add_collivery(new AddColliveryRequest()
                {
                    data = new AddColliveryRequestData(){
                        collection_time = townsResp.collection_time,
                        collivery_from = townsResp.collivery_from,
                        collivery_to = townsResp.collivery_to,
                        collivery_type = townsResp.collivery_type,
                        contact_from = townsResp.contact_from,
                        contact_to = townsResp.contact_to,
                        cover = townsResp.cover,
                        cust_ref = "Invoice # 12234",
                        custom_id = "#12234",
                        delivery_time = townsResp.delivery_time,
                        ignore_validation_change = 0,
                        instructions = "Some custom instructions. Test",
                        parcel_count = townsResp.parcel_count,
                        parcels = townsResp.parcels,
                        price = townsResp.price,
                        service = townsResp.service,
                        time_changed = townsResp.time_changed,
                        time_changed_reason = townsResp.time_changed_reason,
                        vm_divisor = townsResp.vm_divisor,
                        vol_weight = townsResp.vol_weight,
                        weight = townsResp.weight
                    },
                    token = authResp.token
                });

                if(addResp.error == null)
                {
                    txtResult.Text = "Collivery Added: " + addResp.collivery_id;
                }
            }
        }

        private async void btnAcceptCollivery_Click(object sender, EventArgs e)
        {
            Collivery collivery = new Collivery()
            {
                auth = new AuthenticateRequest()
                {
                    email = txtEmail.Text,
                    password = txtPassword.Text
                }
            };

            AcceptColliveryResponse townsResp = await collivery.accept_collivery(new AcceptColliveryRequest()
            {
                collivery_id = 1561587,
                token = authResp.token
            });

            if (townsResp.error != null)
            {
                txtResult.Text = "Error - " + townsResp.error.error;
            }
            else
            {
                txtResult.Text = "Success - Collivery Accept Result: " + townsResp.result;
            }
        }

        private async void btnCancelCollivery_Click(object sender, EventArgs e)
        {
            Collivery collivery = new Collivery()
            {
                auth = new AuthenticateRequest()
                {
                    email = txtEmail.Text,
                    password = txtPassword.Text
                }
            };

            CancelColliveryResponse townsResp = await collivery.cancel_collivery(new CancelColliveryRequest()
            {
                collivery_id = 1565472,
                token = authResp.token
            });

            if (townsResp.error != null)
            {
                txtResult.Text = "Error - " + townsResp.error.error;
            }
            else
            {
                txtResult.Text = "Success - Collivery Cancel Result: " + townsResp.success;
            }
        }
    }
}
