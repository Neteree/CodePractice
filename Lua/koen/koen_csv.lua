M = {}

-- This function was just ment to be a proof of concept, so no
-- checks/data validation was done
function M.to_word_pairs()
  local word_pairs = {}

  for line in io.lines("koen.csv") do
    local ko, en = line:match("%s*(.-),%s*(.*)")
    table.insert(word_pairs, {ko = ko, en = en})
  end

  return word_pairs
end

return M
