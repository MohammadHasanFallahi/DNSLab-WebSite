﻿using DNSLab.DTOs.RestAPI;
using DNSLab.Helper.Exceptions;
using DNSLab.Resources;
using DNSLab.Services;
using Microsoft.AspNetCore.Components;
using Microsoft.Extensions.Localization;
using System.Net;
using System.Text.Json;

namespace DNSLab.Helper.Exceptions
{
    public class HttpResponseExceptionHander
    {

        private readonly NavigationManager _navManager;
        private readonly ToastService _toastService;
        private readonly ApplicationExceptions _applicationExceptions;
        private readonly IStringLocalizer<Resource> _localizer;

        public HttpResponseExceptionHander(NavigationManager navManager, ToastService toastService, ApplicationExceptions applicationException, IStringLocalizer<Resource> localizer)
        {
            _navManager = navManager;
            _toastService = toastService;
            _applicationExceptions = applicationException;
            _localizer = localizer;
        }

        public async Task HandlerExceptionAsync(HttpResponseMessage httpResponseMessage)
        {
            if (!httpResponseMessage.IsSuccessStatusCode)
            {
                if (await ShowToastMessageAsync(httpResponseMessage))
                    return;

                var statusCode = httpResponseMessage.StatusCode;

                switch (statusCode)
                {
                    case HttpStatusCode.NotFound:
                        _navManager.NavigateTo("/404");
                        break;
                    case HttpStatusCode.Unauthorized:
                        if (!_navManager.Uri.ToLower().EndsWith("/user/auth"))
                        {
                            _navManager.NavigateTo("/user/auth");
                            _toastService.ShowToast(_localizer["PleaseLoginFirst"], Enums.ToastLevel.Info);
                        }
                        break;
                    case HttpStatusCode.BadRequest:
                    case HttpStatusCode.Conflict:
                        break;
                    default:
                        _navManager.NavigateTo("/500");
                        break;
                }



            }
        }
        private async Task<bool> ShowToastMessageAsync(HttpResponseMessage response)
        {
            string content = await response.Content!.ReadAsStringAsync();
            if (String.IsNullOrEmpty(content))
                return false;

            var error = JsonSerializer.Deserialize<ErrorDTO>(content!, new JsonSerializerOptions { PropertyNameCaseInsensitive = true });
            var existMessage = _applicationExceptions.GetExceptions().FirstOrDefault(x => x.ExceptionStr == error!.Error);
            if (existMessage != null)
            {
                _toastService.ShowToast(existMessage.NormalMessage, existMessage.Level);
                return true;
            }
            return false;
        }
    }
}
