git remote add other ../ET
git fetch other
git checkout -b ET other/master
git checkout master
git merge ET