using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using SecretSanta.Domain.Models;
using SecretSanta.Domain.Services;

namespace SecretSanta.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GiftController : ControllerBase
    {
        private readonly IGiftService _giftService;

        public GiftController(IGiftService giftService)
        {
            _giftService = giftService ?? throw new ArgumentNullException(nameof(giftService));
        }
        
        // AddGiftToUser
        [HttpPut("{userId}")]
        public ActionResult<DTO.Gift> AddGiftToUser(int userId, DTO.Gift gift)
        {
            if (userId <= 0)
            {
                return NotFound();
            }
            
            Gift domainGift = new Gift()
            {
                Id = gift.Id,
                Title = gift.Title,
                Description = gift.Description,
                OrderOfImportance = gift.OrderOfImportance,
                Url = gift.Url
            };

            _giftService.AddGiftToUser(userId, domainGift);

            return gift;
        }

        // UpdateGiftForUser
        /*[HttpPut()]
        public ActionResult<DTO.Gift> UpdateGiftForUser(int userId)
        {
            return null;
        }*/

        // GET api/Gift/5
        [HttpGet("{userId}")]
        public ActionResult<List<DTO.Gift>> GetGiftForUser(int userId)
        {
            if (userId <= 0)
            {
                return NotFound();
            }
            List<Gift> databaseUsers = _giftService.GetGiftsForUser(userId);

            return databaseUsers.Select(x => new DTO.Gift(x)).ToList();
        }
        
        // Remove gift
        /*[HttpDelete()]
        public void DeleteGiftForUser(int userId)
        {
            
        }*/
    }
}
