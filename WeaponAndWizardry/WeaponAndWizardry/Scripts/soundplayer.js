//Author: Jia Qi Lee (George) Date: 2017-11-15

var effectPlaying;
var backgroundPlaying;
var sounds = [
    { src: "content/sounds/bgm/OpeningTheme1.mp3"   , id: "content/sounds/bgm/OpeningTheme1.mp3"    },
    { src: "content/sounds/bgm/OpeningTheme2.mp3"   , id: "content/sounds/bgm/OpeningTheme2.mp3"    },
    { src: "content/sounds/bgm/PeaceTheme.mp3"      , id: "content/sounds/bgm/PeaceTheme.mp3"       },
    { src: "content/sounds/bgm/CampTheme.mp3"       , id: "content/sounds/bgm/CampTheme.mp3"        },
];

//Loads all the sounds into SoundJs
function loadSound()
{
    createjs.Sound.registerSounds(sounds);
}

//Plays a background sound
function playbgm(soundID)
{
    if (backgroundPlaying != null && backgroundPlaying.playState == "playSucceeded")
        backgroundPlaying.stop();
    var props = new createjs.PlayPropsConfig().set({ loop: -1 });
    console.log(props);
    console.log("Playing: " + soundID);
    backgroundPlaying = createjs.Sound.play(soundID, props);
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
    };

    player.client.playBackground = function (sound) {
        playbgm(sound);
    };

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
    playbgm("content/sounds/bgm/OpeningTheme1.mp3");
}, 3000);