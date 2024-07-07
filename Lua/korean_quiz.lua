math.randomseed(os.time())
local score = 0

local translations = {
  {korean = "하다", english = "to do"},
  {korean = "가다", english = "to go"},
  {korean = "먹다", english = "to eat"},
  {korean = "마시다", english = "to drink"},
  {korean = "자다", english = "to sleep"},
}

local languages = {
  "korean",
  "english"
}

print("\n>>> Enter q to quit <<<\n")

repeat
  print("SCORE: " .. score)
  
  local translation = math.random(#translations)
  local language_a = languages[math.random(#languages)]
  local language_b = language_a == "korean" and "english" or "korean" 
  
  local quetion = translations[translation][language_a]
  local answer = translations[translation][language_b]
  
  io.write(quetion .. ": ")
  local input = string.lower(io.read())
  
  if input == answer then
    score = score + 1
  elseif input ~= "q" then
    score = score - 1
  end
until(input == "q")
