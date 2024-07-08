math.randomseed(os.time())

local Cover = function()
  return {
    material = "",
  }
end

local Page = function(text, page_number)
  return {
    text = text,
    page_number = page_number
  }
end

local Book = function(cover_title, cover_material, number_of_pages) 
  local cover = Cover()
  cover.title = cover_title
  cover.material = cover_material
  local pages = {}
  
  for i = 1, number_of_pages do
    pages[i] = Page("~~" .. string.char(math.random(26) + 64) .. "~~", i)
  end
  
  return {
    cover = cover,
    pages = pages,
    display_info = function()
      local example_page = pages[math.random(#pages)]
      print("Cover Title: " .. cover.title)
      print("Cover material: " .. cover.material)
      print("Number of pages: " .. #pages)
      print("Example Page #" ..example_page.page_number .. ": " .. example_page.text)
      print()
    end
  }
end

local library = {
    Book("book title 1", "paper", 200),
    Book("book title 2", "cloth", 182),
    Book("book title 3", "cloth", 197),
    Book("book title 4", "paper", 222),
    Book("book title 5", "cloth", 124),
    Book("book title 6", "paper", 156),
}

for i = 1, #library do
  local library_book = library[i]
  library_book.display_info()
end
