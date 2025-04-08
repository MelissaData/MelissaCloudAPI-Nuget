using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace MelissaData.CloudAPI
{
  /// <summary>
  /// CloudAPIBase sets the foundation of every CloudApi class.
  /// This class contains variables and methods that all CloudApi classes share
  /// This class contains all the methods that are responsible for sending out API requests
  /// </summary>
  public abstract class CloudAPIBase
  {
    private readonly Dictionary<string, string> baseParameterMappings = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase)
    {
        { nameof(Format), "format" }
    };

    // Private backing fields
    private string _format;
    private string _baseUrl;
    private string _license;
    private string _endpoint;

    // Properties
    public string BaseUrl
    {
      get => _baseUrl;
      set => _baseUrl = value;
    }

    public string License
    {
      get => _license;
      set => _license = value; 
    }

    public string Endpoint
    {
      get => _endpoint;
      set => _endpoint = value; 
    }

    public string Format
    {
      get => _format;
      set
      {
        _format = value;
        parameters[baseParameterMappings[nameof(Format)]] = value;
      }
    }

    protected Dictionary<string, string> parameters;

    public CloudAPIBase(string baseUrl, string endpoint)
    {
      parameters = new Dictionary<string, string>();
      this.BaseUrl = baseUrl;
      this.Endpoint = endpoint;
    }

    public CloudAPIBase()
    {
      parameters = new Dictionary<string, string>();
    }

    // Setters
    public void SetBaseUrl(string baseUrl)
    {
      this.BaseUrl = baseUrl;
    }

    public void SetLicense(string license)
    {
      this.License = license;
    }

    public void SetEndpoint(string endpoint)
    {
      this.Endpoint = endpoint;
    }

    public void SetFormat(string format)
    {
      this.parameters["format"] = format;
      this.Format = format;
    }

    public virtual void SetValue(string parameter, string value)
    {
      parameter = parameter?.Trim();

      if (baseParameterMappings.TryGetValue(parameter, out string parameterKey))
      {
        if (parameterKey == "format")
        {
          Format = value;
        }
        else
        { 
          var propertyInfo = this.GetType().GetProperty(parameter, BindingFlags.IgnoreCase | BindingFlags.Public | BindingFlags.Instance);
          if (propertyInfo != null && propertyInfo.CanWrite)
          {
            propertyInfo.SetValue(this, value);
          }
        }
      }
      else
      {
        throw new ArgumentException($"Parameter '{parameter}' is not recognized in the base class.", nameof(parameter));
      }
    }

    // Getters
    public string GetBaseURL()
    {
      return string.IsNullOrEmpty(this.BaseUrl) ? "" : this.BaseUrl;
    }
    public string GetLicense()
    {
      return string.IsNullOrEmpty(this.License) ? "" : this.License;
    }

    public string GetEndpoint()
    {
      return string.IsNullOrEmpty(this.Endpoint) ? "" : this.Endpoint;
    }

    public string GetFormat()
    {
      return this.parameters.ContainsKey("format") ? this.parameters["format"] : "";
    }

    public string GetValue(string parameter)
    {
      if (parameter.ToLower() == "baseurl")
      {
        return this.GetBaseURL();
      }
      else if (parameter.ToLower() == "license")
      {
        return this.GetLicense();
      }
      else if (parameter.ToLower() == "endpoint")
      {
        return this.GetEndpoint();
      }
      else if (parameter.ToLower() == "format")
      {
        return this.GetFormat();
      }

      return this.parameters.ContainsKey(parameter) ? this.parameters[parameter] : "";
    }

    // Class Methods
    
    /// <summary>
    /// This function clears all the variables set for the CloudAPI but remembers the license, baseUrl, and endpoint
    /// </summary>
    public void Clear()
    {
      this.parameters.Clear();

      this.parameters["format"] = "json";
    }

    /// <summary>
    /// This synchronous function makes the API request using the assembled request URL
    /// </summary>
    /// <param name="url"></param>
    /// <returns>the json response of the CloudAPI as a string</returns>
    protected virtual string GetContents(string url)
    {
      using (HttpClient client = new HttpClient())
      {
        HttpResponseMessage response = client.GetAsync(url).Result;

        string text = response.Content.ReadAsStringAsync().Result;

        var obj = JsonConvert.DeserializeObject(text);
        var prettyResponse = JsonConvert.SerializeObject(obj, Newtonsoft.Json.Formatting.Indented);

        return prettyResponse;
      }
    }

    /// <summary>
    /// This asynchronous function makes the API request using the assembled request URL
    /// </summary>
    /// <param name="url"></param>
    /// <returns>the json response of the CloudAPI as a string</returns>
    protected virtual async Task<string> GetContentsAsync(string url)
    {
      using (HttpClient client = new HttpClient())
      {
        HttpResponseMessage response = await client.GetAsync(url);

        string text = await response.Content.ReadAsStringAsync();

        var obj = JsonConvert.DeserializeObject(text);
        var prettyResponse = JsonConvert.SerializeObject(obj, Newtonsoft.Json.Formatting.Indented);

        return prettyResponse;
      }
    }

    /// <summary>
    /// This synchronous function assembles the request URL and calls GetContents() to make the API request
    /// </summary>
    /// <param name="parameters"></param>
    /// <returns>the json response of the CloudAPI as a string</returns>
    protected virtual string ProcessRequest(Dictionary<string, string> parameters)
    {
      // Create a UriBuilder for constructing the URL
      var uriBuilder = new UriBuilder(this.BaseUrl)
      {
        Path = this.Endpoint
      };

      var query = System.Web.HttpUtility.ParseQueryString(string.Empty);
      query["id"] = this.License;
        

      // Add input parameters
      foreach (KeyValuePair<string, string> kvp in parameters)
      {
        query[kvp.Key] = kvp.Value;
      }

      // Build the string query
      uriBuilder.Query = query.ToString();

      // Make request
      string response = GetContents(uriBuilder.Uri.ToString());

      return response;
    }

    /// <summary>
    /// This asynchronous function assembles the request URL and calls GetContents() to make the API request
    /// </summary>
    /// <param name="parameters"></param>
    /// <returns>the json response if the CloudAPI as a string</returns>
    protected virtual async Task<string> ProcessRequestAsync(Dictionary<string, string> parameters)
    {
      // Create a UriBuilder for constructing the URL
      var uriBuilder = new UriBuilder(this.BaseUrl)
      {
        Path = this.Endpoint
      };

      var query = System.Web.HttpUtility.ParseQueryString(string.Empty);
      query["id"] = this.License;


      // Add input parameters
      foreach (KeyValuePair<string, string> kvp in parameters)
      {
        query[kvp.Key] = kvp.Value;
      }

      // Build the string query
      uriBuilder.Query = query.ToString();

      // Make request
      string response = await GetContentsAsync(uriBuilder.Uri.ToString());

      return response;
    }

    /// <summary>
    /// This synchronous function sends a batch request to the API 
    /// </summary>
    /// <typeparam name="TRecord"></typeparam>
    /// <param name="postRequest"></param>
    /// <returns>the json response of the CloudAPI as a string</returns>
    protected virtual string SendPostRequest<TRecord>(PostRequestBase<TRecord> postRequest)
    {
      try
      {
        using (HttpClient client = new HttpClient())
        {
          client.BaseAddress = new Uri(this.BaseUrl);
          client.DefaultRequestHeaders.Accept.Clear(); // Clear existing accept headers
          client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

          string jsonBatch = JsonConvert.SerializeObject(postRequest);
          StringContent content = new StringContent(jsonBatch, Encoding.UTF8, "application/json");

          HttpResponseMessage response = client.PostAsync(this.Endpoint, content).Result;

          string responseContent = response.Content.ReadAsStringAsync().Result;
          var obj = JsonConvert.DeserializeObject(responseContent);
          var prettyResponse = JsonConvert.SerializeObject(obj, Formatting.Indented);

          return prettyResponse;
        }
      }
      catch (Exception ex)
      {
        return ex.ToString();
      }
    }

    /// <summary>
    /// This is a sychronous helper function that makes the single post request 
    /// </summary>
    /// <param name="postBody"></param>
    /// <returns>a string of the Cloud API response</returns>
    protected virtual string SendPostRequest(RecordRequest postBody)
    {
      try
      {
        using (HttpClient client = new HttpClient())
        {
          client.BaseAddress = new Uri(this.BaseUrl);
          client.DefaultRequestHeaders.Accept.Clear();
          client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

          string jsonRecord = JsonConvert.SerializeObject(postBody);
          StringContent content = new StringContent(jsonRecord, Encoding.UTF8, "application/json");

          HttpResponseMessage response = client.PostAsync(this.Endpoint, content).Result;

          string responseContent = response.Content.ReadAsStringAsync().Result;
          var obj = JsonConvert.DeserializeObject(responseContent);
          var prettyResponse = JsonConvert.SerializeObject(obj, Formatting.Indented);

          return prettyResponse;
        }
      }
      catch (Exception ex)
      {
        return ex.ToString();
      }
    }

    /// <summary>
    /// This asynchronous function sends a batch request to the API 
    /// </summary>
    /// <typeparam name="TRecord"></typeparam>
    /// <param name="postRequest"></param>
    /// <returns>the json response of the CloudAPI as a string</returns>
    protected virtual async Task<string> SendPostRequestAsync<TRecord>(PostRequestBase<TRecord> postRequest)
    {
      try
      {
        using (HttpClient client = new HttpClient())
        {
          client.BaseAddress = new Uri(this.BaseUrl);
          client.DefaultRequestHeaders.Accept.Clear(); // Clear existing accept headers
          client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

          string jsonBatch = JsonConvert.SerializeObject(postRequest);
          StringContent content = new StringContent(jsonBatch, Encoding.UTF8, "application/json");

          HttpResponseMessage response = await client.PostAsync(this.Endpoint, content);

          string responseContent = await response.Content.ReadAsStringAsync();
          var obj = JsonConvert.DeserializeObject(responseContent);
          var prettyResponse = JsonConvert.SerializeObject(obj, Formatting.Indented);

          return prettyResponse;
        }
      }
      catch (Exception ex)
      {
        return ex.ToString();
      }
    }



    /// <summary>
    /// This is an asychronous helper function that makes the single post request 
    /// </summary>
    /// <param name="postBody"></param>
    /// <returns>a string of the Cloud API response</returns>
    protected async Task<string> SendPostRequestAsync(RecordRequest postBody)
    {
      try
      {
        using (HttpClient client = new HttpClient())
        {
          client.BaseAddress = new Uri(this.BaseUrl);
          client.DefaultRequestHeaders.Accept.Clear();
          client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

          string jsonRecord = JsonConvert.SerializeObject(postBody);
          StringContent content = new StringContent(jsonRecord, Encoding.UTF8, "application/json");

          HttpResponseMessage response = await client.PostAsync(this.Endpoint, content);

          string responseContent = await response.Content.ReadAsStringAsync();
          var obj = JsonConvert.DeserializeObject(responseContent);
          var prettyResponse = JsonConvert.SerializeObject(obj, Formatting.Indented);

          return prettyResponse;
        }
      }
      catch (Exception ex)
      {
        return ex.ToString();
      }
    }

    /// <summary>
    /// This function calls ProcessRequest() to send the CloudAPI request and get the response
    /// This function coordinates a string or deserialized response object return
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <returns>a string or deserialized response object</returns>
    public virtual T Get<T>()
    {
      string response = ProcessRequest(parameters);
      return HandleResponse<T>(response);
    }

    /// This function calls ProcessRequest() to send the CloudAPI request and get the response
    /// This function coordinates a string or deserialized response object return
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <returns>a string or deserialized response object</returns>
    public virtual async Task<T> GetAsync<T>()
    {
      string response = await ProcessRequestAsync(parameters);
      return HandleResponse<T>(response);
    }

    /// <summary>
    /// This synchronous function makes a request to the getversion endpoint
    /// </summary>
    /// <returns> a string for the getversion response</returns>
    public virtual string SendVersionRequest()
    {
      try
      {
        using (HttpClient client = new HttpClient())
        {
          client.BaseAddress = new Uri(this.BaseUrl);

          var trimmedEndpoint = this.Endpoint.TrimEnd('/');
          var segments = trimmedEndpoint.Split('/');

          segments[segments.Length - 1] = "getversion";

          var versionEndpoint = string.Join("/", segments);

          HttpResponseMessage response = client.GetAsync(versionEndpoint).Result;

          string responseBody = response.Content.ReadAsStringAsync().Result;
          return responseBody;
        }
      }
      catch (Exception ex) 
      {
        return ex.ToString();
      }
    }

    /// <summary>
    /// This asynchronous function makes a request to the getversion endpoint
    /// </summary>
    /// <returns> a string for the getversion response</returns>
    protected virtual async Task<string> SendVersionRequestAsync()
    {
      try
      {
        using (HttpClient client = new HttpClient())
        {
          client.BaseAddress = new Uri(this.BaseUrl);

          var trimmedEndpoint = this.Endpoint.TrimEnd('/');
          var segments = trimmedEndpoint.Split('/');

          segments[segments.Length - 1] = "getversion";

          var versionEndpoint = string.Join("/", segments);

          HttpResponseMessage response = await client.GetAsync(versionEndpoint);

          string responseBody = await response.Content.ReadAsStringAsync();
          return responseBody;
        }
      }
      catch (Exception ex)
      {
        return ex.ToString();
      }
    }

    /// <summary>
    /// This function determines whether to deserialize the json response or not 
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="response"></param>
    /// <returns>a string or deserializes response object</returns>
    protected T HandleResponse<T>(string response)
    {
      if (typeof(T) == typeof(string))
      {
        return (T)(object)response;
      }
      return JsonConvert.DeserializeObject<T>(response);
    }
  }
}
