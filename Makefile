#make -s (to disable echo)
build: ./src/**/*.cs
	mkdir -p ./bin
	mcs ./src/core/*.cs /target:library /out:./bin/atropos.dll
	if [ -a ./src/tests/*.cs ]; then \
		mcs ./src/tests/*.cs /target:library /out:./bin/atrotests.dll \
		/r:./lib/Contest.Core.dll \
		/r:./bin/atropos.dll; \
	fi;

dbgbuild: ./src/**/*.cs
	mkdir -p ./bin
	mcs ./src/core/*.cs /target:library /out:./bin/atropos.dll
	if [ -a ./src/tests/*.cs ]; then \
		mcs ./src/tests/*.cs /target:library /out:./bin/atrotests.dll \
		/define:DEBUG \
		/r:./lib/Contest.Core.dll \
		/r:./bin/atropos.dll; \
	fi;

test:
	mono ./lib/contest.exe run -nh ./bin/atrotests.dll
