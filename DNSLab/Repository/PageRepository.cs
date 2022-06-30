﻿using DNSLab.DTOs.Comments;
using DNSLab.DTOs.Pages;
using DNSLab.Interfaces.Helper;
using DNSLab.Interfaces.Repository;
using Microsoft.Extensions.Caching.Memory;

namespace DNSLab.Repository
{
    public class PageRepository : IPageRepository
    {
        private readonly IHttpService _httpService;
        private readonly IMemoryCache _memoryCache;

        public PageRepository(IHttpService httpService, IMemoryCache memoryCache)
        {
            this._httpService = httpService;
            this._memoryCache = memoryCache;
        }

        public async Task<bool> AddNewPage(CreatePageDTO createPage)
        {
            var result = await _httpService.Post<CreatePageDTO, bool>($"/Pages/Create", createPage);
            return result.Response;
        }

        public async Task<bool> DeletePage(Guid id)
        {
            var result = await _httpService.Delete<bool>($"/Pages/Delete?Id={id}");
            return result.Response;
        }

        public async Task<bool> EditPage(PageDTO page)
        {
            var result = await _httpService.Put<PageDTO, bool>($"/Pages/Update", page);
            return result.Response;
        }

        public async Task<IEnumerable<PageSummaryDTO>> GetAllPagesSummary()
        {
            var result = await _httpService.Get<IEnumerable<PageSummaryDTO>>($"/Pages/GetAllPagesSummary");
            return result.Response;
        }

        public async Task<IEnumerable<string>> GetAllPagesURL()
        {
            var result = await _httpService.Get<IEnumerable<string>>($"/Pages/GetAllPagesURL");
            return result.Response;
        }

        public async Task<PageDTO> GetPage(Guid id)
        {
            var result = await _httpService.Get<PageDTO>($"/Pages/get?Id={id}");
            return result.Response;
        }

        public async Task<PublishPageDTO> GetPageByURL(string url)
        {
            var result = await _httpService.Get<PublishPageDTO>($"/Pages/getByURL?url={url}");
            return result.Response;
        }

        public async Task<PageMetadataDTO> GetPageMetadata(string url)
        {
            var result = await _httpService.Get<PageMetadataDTO>($"/Pages/GetPageMetaData?url={url}");
            return result.Response;
        }
    }
}
