//Author: Jia Qi Lee (George) Date: 2017-11-15

var stage1 = "content/bgm/stage1.mp3";
var stage2 = "content/bgm/stage2.mp3";
var openingTheme = "content/sounds/bgm/OpeningTheme1.mp3";

function loadSound() {
    createjs.Sound.registerSound(stage1, stage1);
    createjs.Sound.registerSound(stage2, stage2);
    createjs.Sound.registerSound(openingTheme, openingTheme);
}

function playBackground(sound)
{
    console.log("Playing: " + sound);
    if (background != null && background.playState == 'PLAY_SUCCEEDED')
    {
        background.stop();
    }
    var props = new createjs.PlayPropsConfig().set({ loop: -1 });
    background = createjs.Sound.play(sound, props);
}

function playSound(soundID, loop) {
    createjs.Sound.stop();
    var props = new createjs.PlayPropsConfig().set({ loop: Number(loop) });
    console.log(props);
    console.log("Playing: " + soundID);
    createjs.Sound.play(soundID, props);
}

loadSound();

$(function () {
    // Declare a proxy to reference the hub.
    var player = $.connection.soundPlayerHub;

    player.client.play = function (sound, loop) {
        playSound(sound, loop);
    }

    player.client.playBackground = function (sound) {
        playBackground(sound);
    }

    // Start the connection
    $.connection.hub.logging = true;
    $.connection.hub.start().done(function () {
        // Call the Send method on the hub. 
        setTimeout(function () {
            player.server.registerClient();
        }, 1000);
    });
});

//Play the title theme
setTimeout(function () {
    playSound(openingTheme);
}, 3000);