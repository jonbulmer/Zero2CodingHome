﻿using FriendStorage.UI.Events;
using FriendStorage.UI.ViewModel;
using Moq;
using Prism.Events;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit; 

namespace FriendStorage.UITests.ViewModel
{
    public class NavigationItemViewModelTests
    {
        [Fact]
        public void ShouldPublishOpenFriendEditViewEvent()
        {
            var friendId = 7;
            var eventMock = new Mock<OpenFriendEditViewEvent>();
            var eventAggregator = new Mock<IEventAggregator>();
            eventAggregator.Setup(ea => ea.GetEvent<OpenFriendEditViewEvent>()).Returns(eventMock.Object);

            var viewModel = new NavigationItemViewModel(friendId, "Jon", eventAggregator.Object);

            viewModel.OpenFriendEditViewCommand.Execute(null);

            eventMock.Verify(e => e.Publish(friendId), Times.Once);
            
        }  
    }
}